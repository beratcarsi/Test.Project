using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFac.MVC.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            WebSession.ChangeFullName("AHMET 1");
            ViewBag.TestName = WebSession.UserFullName;

            return View();
        }

        public ActionResult Index2()
        {
            WebSession.ChangeFullName("BERAT 2");
            ViewBag.TestName = WebSession.UserFullName;

            return View();
        }

        public ActionResult Show()
        {
            ViewBag.TestName = WebSession.UserFullName;

            return View();
        }
    }
}