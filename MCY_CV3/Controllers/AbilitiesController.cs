﻿using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCY_CV3.Controllers
{
    public class AbilitiesController : Controller
    {
        CV_Context db = new CV_Context();

        [Authorize]
        public ActionResult Index()
        {

            var content = db.Abilities.ToList();

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
        public ActionResult Add(Ability a)
        {
            db.Abilities.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var content = db.Abilities.Find(id);
            db.Abilities.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var content = db.Abilities.Find(id);
            return View("Update", content);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Update(Ability a)
        {
            var content = db.Abilities.Find(a.AbilityID);
            content.Description_EN = a.Description_EN;
            content.Symbol = a.Symbol;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}