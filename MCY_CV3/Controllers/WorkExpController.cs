using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class WorkExpController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {
            var content = db.WorkExps.ToList();

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
        public ActionResult Add(WorkExp a)
        {
            db.WorkExps.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.WorkExps.Find(id);
            db.WorkExps.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.WorkExps.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(WorkExp a)
        {
            var content = db.WorkExps.Find(a.WorkExpID);
            content.Company = a.Company;
            content.Position = a.Position;
            content.StartDate = a.StartDate;
            content.EndDate = a.EndDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}