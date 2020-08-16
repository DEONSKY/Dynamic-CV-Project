using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCY_CV3.Models.Context;

namespace MCY_CV3.Controllers
{
    public class HomeController : Controller
    {
        CV_Context db = new CV_Context();
        public ActionResult Index()
        {
            dynamic IndexModel = new ExpandoObject();
            IndexModel.Abilities = db.Abilities.ToList();
            return View(IndexModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}