namespace SIS.Framework.Views
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using ActionResults.Contracts;
    using HTTP.Common;

    public class View : IRenderable
    {
        private const string RenderBodyConstant = "@RenderBody()";

        //private readonly string fullyQualifiedTemplateName;

        //private readonly IDictionary<string, object> viewData;

        private readonly string fullHtmlContent;

        public View(string fullHtmlContent)
        {
            //this.fullyQualifiedTemplateName = fullyQualifiedTemplateName;
            //this.viewData = viewData;
            this.fullHtmlContent = fullHtmlContent;
        }

        private string ReadFile(string fullyQualifiedTemplateName)
        {
            if (!File.Exists(fullyQualifiedTemplateName))
                throw new FileNotFoundException();

            string fileContent = File.ReadAllText(fullyQualifiedTemplateName);
            return fileContent;
        }

        public string Render()
        {
            //string fullHtml = this.ReadFile(this.fullyQualifiedTemplateName);
            //string renderedHtml = this.RenderHtml(fullHtml);

            //var layoutWithView = this.AddViewToLayout(renderedHtml);

            return this.fullHtmlContent;
        }

        //private string AddViewToLayout(string renderedHtml)
        //{
        //    string layoutViewPath = MvcContext.Get.RootDirectoryRelativePath +
        //        GlobalConstants.DirectorySeparator +
        //        MvcContext.Get.ViewsFolderName +
        //        GlobalConstants.DirectorySeparator +
        //        MvcContext.Get.LayoutViewName +
        //        GlobalConstants.HtmlFileExtension;

        //    if (!File.Exists(layoutViewPath))
        //        throw new FileNotFoundException($"View does not exist at {fullyQualifiedTemplateName}");

        //    string layoutViewContent = File.ReadAllText(layoutViewPath);
        //    string layoutWithView = layoutViewContent.Replace(RenderBodyConstant, renderedHtml);

        //    return layoutWithView;
        //}

        //private string RenderHtml(string fullHtml)
        //{
        //    string renderedHtml = fullHtml;

        //    if (this.viewData.Any())
        //    {
        //        foreach (var parameter in this.viewData)
        //        {
        //            renderedHtml = renderedHtml.Replace($"{{{{{{{parameter.Key}}}}}}}", parameter.Value.ToString());
        //        }
        //    }

        //    return renderedHtml;
        //}
    }
}