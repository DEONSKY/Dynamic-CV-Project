﻿using System;
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

        #region About
        [Authorize]
        public ActionResult About()
        {
            return View();
        }
        #endregion
        #region ComChannels
        [Authorize]
        public ActionResult ComChannels()
        {
            return View();
        }
        #endregion
        #region Education
        [Authorize]
        public ActionResult Education()
        {
            return View();
        }
        #endregion
        #region Hobbies
        [Authorize]
        public ActionResult Hobbies()
        {
            ViewBag.Message = "Your Index2 page.";
            var content = db.Hobbies.ToList();
            return View(content);
        }
        #endregion
        #region Projects
        [Authorize]
        public ActionResult Projects()
        {
            return View();
        }
        #endregion
        #region WorkExps
        [Authorize]
        public ActionResult WorkExps()
        {
            return View();
        }
        #endregion
    }
}