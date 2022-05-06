using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PartyController : Controller
    {
        private UserContext db = new UserContext();
        // GET: Party
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            return View(db.Parties.ToList());
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Party model)
        {
            if (ModelState.IsValid)
            {
                Party party = null;
                using (UserContext db = new UserContext())
                {
                    party = db.Parties.FirstOrDefault(u => u.Number == model.Number);
                }
                if (party == null)
                {
                    using (UserContext db = new UserContext())
                    {

                        db.Parties.Add(new Party { Name = model.Name, Status = model.Status, Number = model.Number, Text = model.Text});

                        db.SaveChanges();

                        party = db.Parties.Where(u => u.Name == model.Name && u.Number == model.Number).FirstOrDefault();
                    }

                    if (party != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Number, true);
                        return RedirectToAction("ThankYou", "Party");
                    }
                }
                if(party != null)
                {
                    db.Parties.Where(u => u.Number == model.Number).FirstOrDefault().Status = model.Status;
                    db.Parties.Where(u => u.Number == model.Number).FirstOrDefault().Text = model.Text;
                    db.SaveChanges();
                    if (party != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Number, true);
                        return RedirectToAction("ThankYou", "Party");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Вы уже отвечали");
                }
            }
            return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}