﻿using ComicBookGallery.Models;
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
        public ActionResult Detail()
        {
            return View();
        }
    }
}
