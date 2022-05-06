using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(Error model)
        {
            String message = model.Message;
            if(message == "error")
            {
                 Response.Redirect("/asdasdasdasd/asdasdasda");
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}