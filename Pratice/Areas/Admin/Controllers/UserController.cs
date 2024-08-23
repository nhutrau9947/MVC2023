using Pratice.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pratice.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username,string passwork)
        {
            mapKhachhang map = new mapKhachhang();
            var login = map.Timkiem(username, passwork);
            if(login!= null)
            {
                return Redirect("/Admin/TrangCheck/Index");
            }

            ViewBag.error = "dang nhap sai mk ";
            return View();
        }
    }
}