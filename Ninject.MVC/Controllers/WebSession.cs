using System;
using System.Web;

namespace Ninject.MVC.Controllers
{
    public class WebSession
    {
        private readonly HttpSessionStateBase _session;

        public WebSession(HttpSessionStateBase session)
        {
            _session = session;
        }

        public WebSession ChangeUserId(int userId)
        {
            _session["userId"] = userId;
            return this;
        }

        public WebSession ChangeFullName(string userFullName)
        {
            _session["userFullName"] = userFullName;
            return this;
        }

        public WebSession ChangeUserRoles(string userRoles)
        {
            _session["userRoles"] = userRoles;
            return this;
        }

        public int UserId => _session["UserId"] != null ? int.Parse(_session["UserId"].ToString()) : -1;

        public string UserFullName => _session["UserFullName"]?.ToString() ?? "-1";

        public string UserRoles => _session["UserRoles"]?.ToString() ?? "-1";

        public void CleanSession()
        {
            _session.Clear();
        }
    }
}