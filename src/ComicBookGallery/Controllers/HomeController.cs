using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            var comicBook = new ComicBookModel()
            { 
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name="Humberto Ramos",Role="Pencils"},
                    new Artist() {Name="Victor Olazaba",Role="Inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Chris Eliopoulos",Role="Letters"},
                }
        };

            
            return View("Detail",comicBook);
        }
    }
}
