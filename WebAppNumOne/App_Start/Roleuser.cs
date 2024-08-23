using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppNumOne.App_Start
{
    public class Roleuser : AuthorizeAttribute
    {
        public string MaChucNang { set; get; }


        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = Session1.GetUser();
            // check session
            if(user == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new
                    {
                        controller = "User",
                        action = "Login",
                        area = "Admin"
                    }));
                return ;
            }
            // check quyen
            if (string.IsNullOrEmpty(MaChucNang)== false)
            {
                var check = new MapPhanQuyen().KiemTra(user.Id, MaChucNang);
                if (check == false)
                {
                    filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new
                    {
                        controller = "Dashboard",
                        action = "Loiphanquyen",
                        area = "Admin"
                    }));
                    return;
                }
            }

            return;
        }
    }
}