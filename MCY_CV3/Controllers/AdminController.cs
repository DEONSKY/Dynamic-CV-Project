using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;

namespace MCY_CV3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        CV_Context db = new CV_Context();


        #region Ability
        public ActionResult Abilities()
        {

            var content = db.Abilities.ToList();

            return View(content);
        }

        [HttpGet]
        public ActionResult AbilityAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AbilityAdd(Ability a)
        {
            db.Abilities.Add(a);
            db.SaveChanges();
            return RedirectToAction("Abilities");
        }

        public ActionResult AbilityDelete(int id)
        {
            var content = db.Abilities.Find(id);
            db.Abilities.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Abilities");
        }

        [HttpGet]
        public ActionResult AbilityUpdate(int id)
        {
            var content = db.Abilities.Find(id);
            return View("AbilityUpdate", content);
        }
        [HttpPost]
        public ActionResult AbilityUpdate(Ability a)
        {
            var content = db.Abilities.Find(a.AbilityID);
            content.Description_EN = a.Description_EN;
            content.Symbol = a.Symbol;
            content.ImageURL = a.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Abilities");
        }
        #endregion
        #region About
        public ActionResult About()
        {
            return View();
        }
        #endregion
        #region ComChannels
        public ActionResult ComChannels()
        {
            return View();
        }
        #endregion
        #region Education
        public ActionResult Education()
        {
            return View();
        }
        #endregion
        #region Hobbies
        public ActionResult Hobbies()
        {
            ViewBag.Message = "Your Index2 page.";
            var content = db.Hobbies.ToList();
            return View(content);
        }
        #endregion
        #region Projects
        public ActionResult Projects()
        {
            return View();
        }
        #endregion
        #region WorkExps
        public ActionResult WorkExps()
        {
            return View();
        }
        #endregion
    }
}