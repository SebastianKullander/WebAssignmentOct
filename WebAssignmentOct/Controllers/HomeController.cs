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

        List<Experience> experiences = new List<Experience>();

        Experience e = new Experience() { education = "Webbutveckling", period = "2014-2015"};
        

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(experiences);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}