using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNumOne.App_Start;

namespace WebAppNumOne.Areas.Admin.Controllers
{
    //[Roleuser]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard

        [Roleuser(MaChucNang = "Xem Khach Hang")]
        public ActionResult Index()
        {
            return View(new mapKhachhang().LoadDanhSach());
        }


        public ActionResult Loiphanquyen()
        {
            return View();
        }
    }
}