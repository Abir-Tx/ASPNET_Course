using RetroTechLanding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroTechLanding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CompanyName = "Retro Tech";
            return View();
        }

        public ActionResult Services() {
            ServicesModel s1 = new ServicesModel()
            {
                Title = "Web Developement",
                Description = "We provide cutting edge web developement service for your business or company",
                Cost = "400$"
            };

            ServicesModel s2 = new ServicesModel()
            {
                Title = "Mobile App Developement",
                Description = "We will make app for IOS, Android in Dart, swift, or java",
                Cost = "700$"
            };

            ServicesModel[] services = new ServicesModel[] {s1, s2};

            return View(services);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}