using System.Web;

namespace AutoFac.MVC.Controllers
{
    public class WebSession
    {
        private static readonly HttpSessionStateBase Session = new HttpSessionStateWrapper(HttpContext.Current.Session);

        public WebSession ChangeUserId(int userId)
        {
            Session["userId"] = userId;
            return this;
        }

        public WebSession ChangeFullName(string userFullName)
        {
            Session["userFullName"] = userFullName;
            return this;
        }

        public WebSession ChangeUserRoles(string userRoles)
        {
            Session["userRoles"] = userRoles;
            return this;
        }

        public static int UserId => Session["UserId"] != null ? int.Parse(Session["UserId"].ToString()) : -1;

        public static string UserFullName => Session["UserFullName"].ToString();

        public static string UserRoles => Session["UserRoles"].ToString();

        public void CleanSession()
        {
            Session.Clear();
        }
    }
}