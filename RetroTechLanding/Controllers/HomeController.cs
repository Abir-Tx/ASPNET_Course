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

		public ActionResult Services()
		{
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

			ServicesModel[] services = new ServicesModel[] { s1, s2 };

			return View(services);
		}

		public ActionResult Terms_Mems()
		{
			MembersModel[] members = new MembersModel[]
			{
				new MembersModel("Abir", "23", "C++, ASP.NET, Python"),
				new MembersModel("Nibir", "18", "Dart, Xamarin"),
				new MembersModel("Alex", "20", "C#, Java, Python"),
				new MembersModel("John", "19", "C++, C#, Java"),
				new MembersModel("Smith", "21", "HTML, C#, R"),
				new MembersModel("Doe", "22", "C++, C#, Java")
			};
			return View(members);
		}

		public ActionResult Contact() => View();
	}
}