using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class EducationController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {
            var content = db.Education.ToList();

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
        public ActionResult Add(Education a)
        {
            db.Education.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.Education.Find(id);
            db.Education.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.Education.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(Education a)
        {
            var content = db.Education.Find(a.EducationID);
            content.Description_EN = a.Description_EN;
            content.StartDate = a.StartDate;
            content.EndDate = a.EndDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}