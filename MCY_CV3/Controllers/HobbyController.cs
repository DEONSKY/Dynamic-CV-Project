using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class HobbyController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {
            var content = db.Hobbies.ToList();

            return View(content);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Add(Hobby a)
        {
            db.Hobbies.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.Hobbies.Find(id);
            db.Hobbies.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.Hobbies.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(Hobby a)
        {
            var content = db.Hobbies.Find(a.HobbyID);
            content.Description_EN = a.Description_EN;
            content.Symbol = a.Symbol;
            content.ImageURL = a.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}