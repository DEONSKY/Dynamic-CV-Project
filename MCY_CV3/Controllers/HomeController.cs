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
            IndexModel.Abouts = db.Abouts.ToList();
            IndexModel.Admin = db.Admin.ToList();
            List<WorkExp> WorkExpR = db.WorkExps.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.WorkExpR = WorkExpR.First();
            IndexModel.MainCom = db.ComChannels.Where(
                x => x.Title_EN == "Youtube" ||
                x.Title_EN == "LinkedIn" ||
                x.Title_EN == "Github" ||
                x.Title_EN == "Gmail").ToList();
            IndexModel.ComChannels = db.ComChannels.ToList();
            IndexModel.Location = db.ComChannels.Where(
                x => x.Title_EN == "Location").ToList();
            return View(IndexModel);
        }
        public ActionResult Projects()
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
            IndexModel.Projects = db.Projects.ToList();

            return View(IndexModel);
        }
        public ActionResult EdcWorkExp()
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
            IndexModel.WorkExps = db.WorkExps.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.Education = db.Education.OrderByDescending(x => x.StartDate).ToList();
            IndexModel.TechKnowWondering = db.TechKnow.Where(x => x.KnowLvl == 0 ).ToList();
            IndexModel.TechKnowBasic = db.TechKnow.Where(x => x.KnowLvl > 0 && x.KnowLvl <= 40).ToList();
            IndexModel.TechKnowModerate = db.TechKnow.Where(x => x.KnowLvl > 40 && x.KnowLvl <= 70).ToList();
            IndexModel.TechKnowExpert = db.TechKnow.Where(x => x.KnowLvl > 70 && x.KnowLvl <= 100).ToList();

            return View(IndexModel);
        }
        public ActionResult Hobbies()
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
            IndexModel.Hobbies = db.Hobbies.ToList();

            return View(IndexModel);
        }

    }
}