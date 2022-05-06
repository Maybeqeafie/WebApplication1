using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(LoginModel model)
        {
            return View(model);
        }

        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Input(Input model)
        {
            return View(model);
        }
    }
}