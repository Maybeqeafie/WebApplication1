using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index(Calculator model)
        {
            double x;
            double y;
            double c = 0;
            if(double.TryParse(model.X, out x) && double.TryParse(model.Y, out y))
            { 
            switch (model.Operation)
            {
                case "Plus":
                    c = x + y;
                    ViewBag.Result = c;
                    break;
                case "Minus":
                    c = x - y;
                    ViewBag.Result = c;
                    break;
                case "Multiply":
                    c = x * y;
                    ViewBag.Result = c;
                    break;
                case "Division":
                    if (y == 0)
                    {
                        ViewBag.Result = "Не определен";
                        break;
                    }
                    else
                    {
                        c = x / y;
                        ViewBag.Result = c;
                        break;
                    }
            }
            }
            else
            {
                ViewBag.Result = "NaN";
            }

            return View();
        }
    }
}