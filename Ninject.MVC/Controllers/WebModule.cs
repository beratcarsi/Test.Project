using System.Web;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Ninject.MVC.Controllers
{
    public class WebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<WebSession>()
                .ToConstructor(x=> new WebSession(new HttpSessionStateWrapper(HttpContext.Current.Session)))
                .InRequestScope();

            Bind<BindTest>().ToSelf().InSingletonScope();
        }
    }
}