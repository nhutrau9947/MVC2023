using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppNumOne.App_Start
{
    public class SessionConfig
    {
        // Luu user
        public void SetUser(Taikhoan user)
        {
            // luu vao sesson
            HttpContext.Current.Session["user"] = user;
        }
    }
}