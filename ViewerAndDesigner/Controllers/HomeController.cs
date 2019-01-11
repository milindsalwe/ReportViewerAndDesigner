﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewerAndDesigner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("../Viewer/Index");

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Designer()
        {
            return RedirectToAction("Index", "Designer");
        }

        public ActionResult Viewer()
        {
            return RedirectToAction("Index", "Viewer");
        }
    }
}