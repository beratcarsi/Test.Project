using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ninject.MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly BindTest _bindTest;

        public HomeController(BindTest bindTest)
        {
            _bindTest = bindTest;
        }

        public ActionResult Index()
        {
            var name = _bindTest.ChangeName("AHMET");

            WebSession.ChangeFullName("AHMET 1");
            ViewBag.TestName = WebSession.UserFullName;

            //WebSession.ChangeFullName("AHMET");

            return View("Index");
        }

        public ActionResult About()
        {
            var name = _bindTest.ChangeName("BERAT");

            WebSession.ChangeFullName("BERAT 2");
            ViewBag.TestName = WebSession.UserFullName;

            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TestName = WebSession.UserFullName;

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}