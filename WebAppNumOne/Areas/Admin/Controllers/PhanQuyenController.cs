using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppNumOne.Areas.Admin.Controllers
{
    public class PhanQuyenController : Controller
    {
        // GET: Admin/PhanQuyen
        public ActionResult DanhsachTaiKhoan()
        {
            return View(new mapTaiKhoan().Danhsach().ToList());
        }
    }
}