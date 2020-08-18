using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class ProjectController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {
            var content = db.Projects.ToList();

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
        public ActionResult Add(Project a)
        {
            db.Projects.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.Projects.Find(id);
            db.Projects.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.Projects.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(Project a)
        {
            var content = db.Projects.Find(a.ProjectID);
            content.Title_EN = a.Title_EN;
            content.Description_EN = a.Description_EN;
            content.Link = a.Link;
            content.ImageURL = a.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}