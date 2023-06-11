using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Homepage()
        {
            ViewBag.Name = "NasifAhmed Inc.";
            ViewBag.Bio = "A leading provider of IT software solutions. We offer a wide range of products and services, including software development, consulting, and training. Our team of experienced professionals is dedicated to providing our customers with the best possible solutions.";
            return View();
        }

        public ActionResult Services()
        {
      
            return View();
        }

        public ActionResult Teams_and_members()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}