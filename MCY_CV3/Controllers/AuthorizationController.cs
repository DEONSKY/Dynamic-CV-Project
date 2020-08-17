using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCY_CV3.Models.Context;
using MCY_CV3.Models.Tables;
using System.Web.Security;

namespace MCY_CV3.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        CV_Context db = new CV_Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin y)
        {
            var info = db.Admin.FirstOrDefault(x => x.FirstKey == y.FirstKey && x.SecondKey == y.SecondKey);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Name, false);
                return RedirectToAction("Abilities","Admin");
            }
            else
            {
                return View();
            }
        }
    }
}