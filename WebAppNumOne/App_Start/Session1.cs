using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppNumOne.App_Start
{
    public static class Session1
    {
        // luu session
        public static  void SetUser(Taikhoan user)
        {
            HttpContext.Current.Session["user"] = user;
        }
        // lay session
        public static Taikhoan GetUser()
        {
            // luu vao session
            return (Taikhoan)HttpContext.Current.Session["user"];
        }
    }
}