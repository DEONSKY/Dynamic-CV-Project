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
    public class HomeController : Controller
    {
        CV_Context db = new CV_Context();

        public ActionResult HomeLayout()
        {
            dynamic IndexModel = new ExpandoObject();
            IndexModel.Abouts = db.Abouts.ToList();
            IndexModel.Admin = db.Admin.ToList();
            List<WorkExp> WorkExpR = db.WorkExps.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.WorkExpR = WorkExpR.First();
            IndexModel.MainCom = db.ComChannels.Where(
                x => x.Title_EN == "Youtube" ||
                x.Title_EN == "LinkedIn" ||
                x.Title_EN == "Github" ||
                x.Title_EN == "Gmail").ToList();
            return PartialView(IndexModel);
        }
        public ActionResult Index()
        {
            dynamic IndexModel = new ExpandoObject();
            IndexModel.Abouts = db.Abouts.ToList();
            IndexModel.Abilities = db.Abilities.ToList();
            IndexModel.Admin = db.Admin.ToList();
            List<WorkExp> WorkExpR = db.WorkExps.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.WorkExpR = WorkExpR.First();
            IndexModel.MainCom = db.ComChannels.Where(
                x => x.Title_EN == "Youtube" ||
                x.Title_EN == "LinkedIn" ||
                x.Title_EN == "Github" ||
                x.Title_EN == "Gmail").ToList();

            return View(IndexModel);
        }
        public ActionResult Communication()
        {
            dynamic IndexModel = new ExpandoObject();
            IndexModel.Abilities = db.Abilities.ToList();
            IndexModel.Abouts = db.Abouts.ToList();
            IndexModel.Admin = db.Admin.ToList();
            List<WorkExp> WorkExpR = db.WorkExps.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.WorkExpR = WorkExpR.First();
            IndexModel.MainCom = db.ComChannels.Where(
                x => x.Title_EN == "Youtube" ||
                x.Title_EN == "LinkedIn" ||
                x.Title_EN == "Github" ||
                x.Title_EN == "Gmail").ToList();

            return View(IndexModel);
        }

    }
}