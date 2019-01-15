namespace SIS.Framework.Routers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Net;
    using System.Reflection;

    using ActionResults.Contracts;
    using Attributes.Methods;
    using Controllers;
    using HTTP.Requests.Contracts;
    using HTTP.Responses.Contracts;
    using Services.Contracts;
    using SIS.Framework.Attributes.Action;
    using WebServer.Contracts.Api;
    using WebServer.Results;

    public class ControllerRouter : IHttpHandler
    {
        private const string UnsupportedActionMessage = "The view result is not supported.";

        private const string ControllerName = "Controller";

        private readonly IDependencyContainer dependencyContainer;

        public ControllerRouter(IDependencyContainer dependencyContainer)
        {
            this.dependencyContainer = dependencyContainer;
        }

        private Controller GetController(string controllerName)
        {
            if (controllerName == null)
                return null;

            string controllerTypeName = String.Format("{0}.{1}.{2}{3}, {0}",
                MvcContext.Get.AssemblyName,
                MvcContext.Get.ControllersFolder,
                controllerName,
                MvcContext.Get.ControllerSuffix);

            Type controllerType = Type.GetType(controllerTypeName);
            var controller = (Controller)this.dependencyContainer.CreateInstance(controllerType);
            return controller;
        }

        private MethodInfo GetAction(string requestMethod, Controller controller, string actionName)
        {
            MethodInfo method = null;

            foreach (MethodInfo methodInfo in this.GetSuitableMethods(controller, actionName))
            {
                IEnumerable<HttpMethodAttribute> attributes = methodInfo
                    .GetCustomAttributes()
                    .Where(attr => attr is HttpMethodAttribute)
                    .Cast<HttpMethodAttribute>();

                if (!attributes.Any() && requestMethod.ToUpper() == "GET")
                    return methodInfo;

                foreach (HttpMethodAttribute attribute in attributes)
                {
                    if (attribute.IsValid(requestMethod))
                        return methodInfo;
                }
            }

            return method;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods(Controller controller, string actionName)
        {
            if (controller == null)
                return new MethodInfo[0];

            return controller.GetType().GetMethods()
                .Where(methodInfo => methodInfo.Name.ToLower() == actionName.ToLower());
        }

        private IHttpResponse PrepareResponse(IActionResult actionResult)
        {
            string invocationResult = actionResult.Invoke();

            if (actionResult is IViewable)
                return new HtmlResult(invocationResult, HttpStatusCode.OK);
            else if (actionResult is IRedirectable)
                return new RedirectResult(invocationResult);

            throw new InvalidOperationException(UnsupportedActionMessage);
        }

        public IHttpResponse Handle(IHttpRequest request)
        {
            string controllerName = String.Empty;
            string actionName = String.Empty;
            string requestMethod = request.RequestMethod.ToString();

            if (request.Url == "/")
            {
                controllerName = "Home";
                actionName = "Index";
            }
            else
            {
                string[] requestUrlSplit = request.Url.Split("/", StringSplitOptions.RemoveEmptyEntries);

                controllerName = requestUrlSplit[0];
                actionName = requestUrlSplit[1];
            }

            Controller controller = this.GetController(controllerName);
            MethodInfo action = this.GetAction(requestMethod, controller, actionName);
            if (controller == null || action == null)
                throw new NullReferenceException();

            controller.Request = request;

            object[] actionParameters = this.MapActionParameters(action, request, controller);
            IActionResult actionResult = this.InvokeAction(controller, action, actionParameters);

            return 
                this.Authorize(controller, action) ??
                this.PrepareResponse(this.InvokeAction(controller, action, actionParameters));
        }

        private IActionResult InvokeAction(Controller controller, MethodInfo action, object[] actionParameters)
        {
            return (IActionResult)action.Invoke(controller, actionParameters);
        }

        private object[] MapActionParameters(MethodInfo action, IHttpRequest request, Controller controller)
        {
            ParameterInfo[] actionParametersInfo = action.GetParameters();
            object[] mappedActionParameters = new object[actionParametersInfo.Length];

            for (int index = 0; index < actionParametersInfo.Length; index++)
            {
                ParameterInfo currentParameterInfo = actionParametersInfo[index];

                if (currentParameterInfo.ParameterType.IsPrimitive ||
                    currentParameterInfo.ParameterType == typeof(string))
                {
                    mappedActionParameters[index] = this.ProcessPrimitiveParameters(currentParameterInfo, request);
                }
                else
                {
                    object bindingModel = this.ProcessBindingModelParameters(currentParameterInfo, request);
                    controller.ModelState.IsValid = this.IsValidModel(bindingModel, currentParameterInfo.ParameterType);
                    mappedActionParameters[index] = bindingModel;
                }
            }

            return mappedActionParameters;
        }

        private bool? IsValidModel(object bindingModel, Type bindingModelType)
        {
            PropertyInfo[] properties = bindingModelType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var propertyValidationAttributes = property
                    .GetCustomAttributes()
                    .Where(x => x is ValidationAttribute)
                    .Cast<ValidationAttribute>()
                    .ToList();

                foreach (ValidationAttribute validationAttribute in propertyValidationAttributes)
                {
                    var propertyValue = property.GetValue(bindingModel);
                    if (!validationAttribute.IsValid(propertyValue))
                        return false;
                }
            }

            return true;
        }

        private object ProcessBindingModelParameters(ParameterInfo param, IHttpRequest request)
        {
            Type bindingModelType = param.ParameterType;

            object bindingModelInstance = Activator.CreateInstance(bindingModelType);
            PropertyInfo[] bindingModelProperties = bindingModelType.GetProperties();

            foreach (PropertyInfo property in bindingModelProperties)
            {
                try
                {
                    object value = this.GetParameterFromRequestData(request, param.Name);
                    property.SetValue(bindingModelInstance, Convert.ChangeType(value, property.PropertyType));
                }
                catch
                {
                    Console.WriteLine($"The {property.Name} field could not be mapped.");
                }
            }

            return Convert.ChangeType(bindingModelInstance, bindingModelType);
        }

        private object ProcessPrimitiveParameters(ParameterInfo param, IHttpRequest request)
        {
            object value = this.GetParameterFromRequestData(request, param.Name);
            return Convert.ChangeType(value, param.ParameterType);
        }

        private object GetParameterFromRequestData(IHttpRequest request, string paramName)
        {
            if (request.QueryData.ContainsKey(paramName))
                return request.QueryData[paramName];

            if (request.FormData.ContainsKey(paramName))
                return request.FormData[paramName];

            return null;
        }

        private IHttpResponse Authorize(Controller controller, MethodInfo action)
        {
            if (action
                .GetCustomAttributes()
                .Where(x => x is AuthorizeAttribute)
                .Cast<AuthorizeAttribute>()
                .Any(x => !x.IsAuthorized(controller.Identity)))
            {
                return new UnauthorizedResult();
            }

            
            return null;
        }
    }
}