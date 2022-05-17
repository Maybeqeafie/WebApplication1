
using System.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CacheController : Controller
    {
        private UserContext db = new UserContext();


        [HttpGet]
        public ActionResult Index()
        {
            List<People> clients = MemoryCache.Default.Get("Clients") as List<People>;
            if (clients == null)
            {
                clients = new List<People>();
                foreach (People c in db.Peoples)
                {
                    People client = new People();
                    client.Name = c.Name;
                    client.Reward = c.Reward;
                    clients.Add(client);
                }
                MemoryCache.Default.Add("Clients", clients, DateTimeOffset.Now.AddMinutes(1));
                ViewBag.Text = "Некешированные данные";
            }
            else
            {
                ViewBag.Text = "Данные из кеша";

            }
            return View(clients);
        }
    }
}