using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class TechKnowController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {
            var content = db.TechKnow.ToList();

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
        public ActionResult Add(TechKnow a)
        {
            db.TechKnow.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.TechKnow.Find(id);
            db.TechKnow.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.TechKnow.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(TechKnow a)
        {
            var content = db.TechKnow.Find(a.TechKnowID);
            content.Description_EN= a.Description_EN;
            content.KnowLvl = a.KnowLvl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}