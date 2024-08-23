using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppNumOne.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult NhanVien()
        {
            mapKhachhang map2 = new mapKhachhang();
            var ds = map2.LoadDanhSachNV();
            return View(ds);
        }
    }
}