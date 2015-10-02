using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ScreenTest.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OpenLogin()
        {
            return PartialView("_LoginPartial");

        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            ViewData["LogOff"] = true;
            Session["user"] = null;
            return PartialView("LoginButton");

        }

        public ActionResult GetLoginButton()
        {
            ViewData["LogOff"] = null;
            return PartialView("LoginButton");
        }
        public ActionResult Login(string username, string password)
        {
            FormsAuthentication.SetAuthCookie(username,false);
            Session["user"] = username;
            return Json (new { Success=true});

            //return PartialView("LoginButton");
        }
    }
}
