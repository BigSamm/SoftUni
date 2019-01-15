namespace SIS.Framework.Utilities
{
    using System;

    public static class ControllerUtilities
    {
        public static string GetControllerName(object controller)
        {
            return controller.GetType().Name.Replace(MvcContext.Get.ControllerSuffix, String.Empty);
        }

        public static string GetViewFullQualifiedName(string controller, string action)
        {
            return String.Format("../../../{0}/{1}/{2}.html", MvcContext.Get.ViewsFolderName, controller, action);
        }
    }
}
