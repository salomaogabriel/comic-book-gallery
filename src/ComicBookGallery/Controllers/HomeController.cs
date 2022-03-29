using Microsoft.AspNetCore.Mvc;
using ComicBookGallery.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookRepository _comicBookRepository;
        public HomeController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Index(int? id)
        {
            return Detail(id);
        }
        public ActionResult Privacy(int? id)
        {
            return Detail(id);
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            
            return View("Detail",_comicBookRepository.GetComicBook((int)id));
        }
    }
}
