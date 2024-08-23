using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using static DATA.mapKhachhang;
using WebAppNumOne.App_Start;

namespace WebAppNumOne.Areas.Admin.Controllers
{
    //[Roleuser]
    public class QuanLyKhachHangController : Controller
    {

        // GET: Admin/QuanLyKhachHang

        [Roleuser(MaChucNang ="Xem Khach Hang")]
        public ActionResult Danhsach()
        {
            var map = new mapKhachhang();
            var data = map.LoadDanhSach().ToList();
            return View(data);
        }

        // Tim kiem
        [HttpPost]
        public ActionResult Danhsach(string TimKiem)
        {
            var map = new mapKhachhang();
            var data = map.LoadDanhSach().Where(m=>m.TenKhachHang == TimKiem).ToList();
            if(data.Count == 0)
            {
                return RedirectToAction("Danhsach");
            }
            else
            {
                return View(data);
            }

        }


        public ActionResult ThemMoi()
        {
            return View(new Khachhang() { NgaySinh = DateTime.Now, SoTien = 0});
        }
        [HttpPost]
        public ActionResult ThemMoi(Khachhang model)
        {
            var map = new mapKhachhang();
            var id =  map.ThemMoi(model);
            if(id > 0 )
            {
                return RedirectToAction("Danhsach");
            }
            else
            {
                ModelState.AddModelError("","Nhập bị lỗi");
                return View(model);
            }
        }
        // cập nhật 
        public ActionResult CapNhat(int ID)
        {
            var doituongcapnhat = new mapKhachhang().ChiTiet(ID);
            return View(doituongcapnhat);
        }
        [HttpPost]
        public ActionResult CapNhat(Khachhang model)
        {
            var map = new mapKhachhang();
            // thuc hien ok thi true, loi thi false
            if(map.CapNhat(model)== true)
            {
               return RedirectToAction("Danhsach");
            }
            else
            {
                return View(model);
            }
        }
        // Xoa thong tin khach hang
        public ActionResult Xoa(int ID)
        {
            var map = new mapKhachhang();
            map.Xoa(ID);
            return RedirectToAction("Danhsach");
        }

    }
}