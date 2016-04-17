using System.Web.Mvc;

namespace AutoFac.MVC.Controllers
{
    public class BaseController : Controller
    {
        public WebSession WebSession { get; set; }

        public BaseController()
        {
            WebSession = new WebSession();
        }
    }
}