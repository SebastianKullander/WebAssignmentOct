using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAssignmentOct.Models;

namespace WebAssignmentOct.Controllers
{
    public class HomeController : Controller

    {

        private List<Experience> experiences;
        T4DBEntities MyDataBase = new T4DBEntities();

        public HomeController() {
            experiences = new List<Experience>();
            //experiences.Add(new Experience() { education = "Webbutveckling", period = "2014-2015" });
            //experiences.Add(new Experience() { education = "Digitalt skapande", period = "2014-2015" });
            //experiences.Add(new Experience() { education = "Gränssnittsdesign", period = "2014-2015" });
            //experiences.Add(new Experience() { education = "Webbserverprogrammering", period = "2015-2016" });
            //experiences.Add(new Experience() { education = "Programmering", period = "2015-2016" });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(MyDataBase);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}