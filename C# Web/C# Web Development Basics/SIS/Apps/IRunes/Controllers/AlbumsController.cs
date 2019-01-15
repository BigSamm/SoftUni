namespace IRunes.Controllers
{
    using Services.Contracts;
    using ViewModels;
    using SIS.Framework.ActionResults.Contracts;
    using SIS.Framework.Attributes.Methods;
    using SIS.Framework.Controllers;

    public class AlbumsController : Controller
    {
        private readonly IAlbumsService albumsService;

        public AlbumsController(IAlbumsService albumsService)
        {
            this.albumsService = albumsService;
        }
        
        public IActionResult All()
        {
            return base.View();
        }
        
        public IActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Create(CreateAlbumViewModel model)
        {
            if (!base.ModelState.IsValid.HasValue || !base.ModelState.IsValid.Value)
                return base.RedirectToAction("/Albums/Create");

            bool isSuccessfully = this.albumsService.TryAddToDatabase(model.Name, model.Cover);
            if (!isSuccessfully)
                return base.RedirectToAction("Albums/Create");

            return base.RedirectToAction("Albums/All");
        }
        
        internal IActionResult Details()
        {
            return base.View();
        }
    }
}