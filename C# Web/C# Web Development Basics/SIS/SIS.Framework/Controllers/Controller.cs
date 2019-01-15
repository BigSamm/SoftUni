namespace SIS.Framework.Controllers
{
    using System.IO;
    using System.Runtime.CompilerServices;

    using ActionResults;
    using ActionResults.Contracts;
    using HTTP.Requests.Contracts;
    using Models;
    using Security.Contracts;
    using Utilities;
    using Views;

    public abstract class Controller
    {
        protected Controller()
        {
            this.ViewModel = new ViewModel();
            this.ModelState = new Model();
            this.ViewEngine = new ViewEngine();
        }

        public IHttpRequest Request { get; set; }

        protected ViewModel ViewModel { get; }

        public Model ModelState { get; }

        private ViewEngine ViewEngine { get; }

        public IIdentity Identity => (IIdentity)this.Request.Session.GetParameter("auth");

        protected IViewable View([CallerMemberName] string actionName = "")
        {
            string controllerName = ControllerUtilities.GetControllerName(this);
            string viewContent = null;

            try
            {
                viewContent = this.ViewEngine.GetViewContent(controllerName, actionName);
            }
            catch (FileNotFoundException ex)
            {
                this.ViewModel.Data["Error"] = ex.Message;

                viewContent = this.ViewEngine.GetErrorContent();
            }

            string renderedContent = this.ViewEngine.RenderHtml(viewContent, this.ViewModel.Data);
            return new ViewResult(new View(renderedContent));
        }

        protected IRedirectable RedirectToAction(string redirectUrl)
        {
            return new RedirectResult(redirectUrl);
        }

        protected void SignIn(IIdentity auth)
        {
            this.Request.Session.AddParameter("auth", auth);
        }

        protected void SignOut()
        {
            this.Request.Session.ClearParameters();
        }
    }
}