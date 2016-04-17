using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ninject.MVC.Controllers
{
    public class BaseController : Controller
    {
        [Inject]
        public WebSession WebSession { get; set; }

    }
}