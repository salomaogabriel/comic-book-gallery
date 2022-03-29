using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return Detail();
        }
        public ActionResult Privacy()
        {
            return Detail();
        }

        public ActionResult Detail()
        {
            
            
            return View("Detail",);
        }
    }
}
