using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AFPortfolio2022.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Projects()
        {
           
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }
    }
}