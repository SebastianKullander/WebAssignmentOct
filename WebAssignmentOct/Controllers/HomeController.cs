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

        T4DBEntities MyDataBase = new T4DBEntities();

        public HomeController() {

        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(new T4DBEntities().Tables.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}