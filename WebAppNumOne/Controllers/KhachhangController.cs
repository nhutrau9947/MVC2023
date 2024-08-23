using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNumOne.Models;
using DATA;

namespace WebAppNumOne.Controllers
{
    public class KhachhangController : Controller
    {
        // GET: Khachhang
        //public ActionResult Danhsach(string hoTen)
        //{
        //    var data =Sokhachhang.DS_KhachHang.Where(m => m.HovaTen.ToLower() == hoTen.ToLower()).ToList();

        //    var Dscapnhat = Sokhachhang.DS_KhachHang.SingleOrDefault(m => m.Diachi == "thon8");
        //    if (Dscapnhat != null)
        //    {
        //        Dscapnhat.Diachi = "thon6";
        //    }
        //    return View(data);
        //}
        public ActionResult DanhSach()
        {
            mapKhachhang map2 = new mapKhachhang();
            var ds = map2.Phantrang(0,10);
            return View(ds);
        }
    }
}