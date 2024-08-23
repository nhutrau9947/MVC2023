using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppNumOne.Models;

namespace WebAppNumOne.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

            // Cách truyền dữ liệu từ Controller sang View
            // ViewBag
            // Temdada
            // Model
            // list Model 
        public ActionResult TrangChu()
        { 
            ViewBag.TuiA = "AAAAAAAAAAAAAA";  // chỉ truyên được trong cùng ActionResult
            ViewData["Nhut"] = "BBBBBBBBBBB"; // truyền được ngoài Action nhưng chỉ một lần

            var db1 = new Data();
            db1.Title = "HIIIIIIIII";
            db1.Des = "MAAAAAAAAAAAAA";

            var db2 = new Data();
            db2.Title = "3333333";
            db2.Des = "4444444444";

            List<Data> dsData = new List<Data>();
            dsData.Add(db1);
            dsData.Add(db2);



            return View(dsData);

        }
        // giao dien nhap lieu
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult FormNHan(string loichao, DateTime? ngaygui )
        {
            ViewBag.loichao = loichao; // tham so truyen vao banng ten cua FORM nhap lieu
            ViewBag.ngaygui = ngaygui;
            return View();
        }

        public ActionResult FormKhachHang()
        {
            KhachHang kh1 = new KhachHang();
            //kh1.Chungchi = new string[] {"Nam","Nu","Khac" };
            return View(kh1);
        }
        [HttpPost]
        public ActionResult FormKhachHang(KhachHang Model)
        {
            // 1.Thêm mới 1 đối tượng mới vào DS
            Sokhachhang2.DS_KhachHang.Add(Model);
            // 2.Thêm mới nhiều  đối tượng mới vào DS

            //List<KhachHang> SoNho = new List<KhachHang>();
            //Sokhachhang.DS_KhachHang.AddRange(SoNho);
            // 3.Tim kiem 1 đối tượng(nếu nhiều đối tượng sẽ bị lỗi)

            //var kh0 = Sokhachhang.DS_KhachHang.Find(); // Tim theo Id (Khoa chinh)
            //var kh1 = Sokhachhang.DS_KhachHang.SingleOrDefault(item => item.HovaTen == "Nguyen Van A");
            //var kh2 = Sokhachhang.DS_KhachHang.FirstOrDefault(item => item.HovaTen == "Nguyen Van A");
            //var kh3 = Sokhachhang.DS_KhachHang.Last(item => item.HovaTen == "Nguyen Van A");

            // 4.Tìm nhiều đối tượng (danh sach)
            //var kh2000 = Sokhachhang.DS_KhachHang.Where(item => item.Namsinh == 2000).ToList();

            // 5.Sắp xếp Oder by
            //var khNamsinhgiamdan = Sokhachhang.DS_KhachHang.OrderBy(item => item.Namsinh).ThenBy(item=> item.Namsinh);

            // 6.Update đối tượng 
            // - Tìm đối tượng cần update
            // - Cập nhật thông tin


            //var SvNhutTV = Sokhachhang.DS_KhachHang.SingleOrDefault(item => item.CCCD == "123456789");

            //if (SvNhutTV != null)
            //{
            //    SvNhutTV.NgaySinh = new DateTime(2022, 12, 2); 
            //}

            // 7.Xóa một danh sách
            // Tìm đối tượng cần xóa
            // Xóa 1 ds


            //var SvNhutTV = Sokhachhang.DS_KhachHang.SingleOrDefault(item => item.CCCD == "123456789");// tìm 1 đối tượng cần xóa
            //Sokhachhang.DS_KhachHang.Remove(SvNhutTV);

            var Dscanxoa = Sokhachhang2.DS_KhachHang.Where(item => item.CCCD == "123456789").ToList();// 1 ds cần xóa
            //Sokhachhang.DS_KhachHang.RemoveRange(Dscanxoa);// hàm này sử dụng khi dùng database

            foreach (var item in Dscanxoa)
            {
                Sokhachhang2.DS_KhachHang.Remove(item);
            }

            // 8.Tính Tổng, đếm, trung bình 

            //var Sum = Sokhachhang.DS_KhachHang.Sum(item => item.Namsinh);
            //var Dem1 = Sokhachhang.DS_KhachHang.Count(item => item.Namsinh == 1990);
            //var Dem2 = Sokhachhang.DS_KhachHang.Count();
            //var Dem3 = Sokhachhang.DS_KhachHang.Count;
            //var trungbinh = Sokhachhang.DS_KhachHang.Average(m => m.Namsinh);

            //// 9. Lấy dữ liệu
            //var listNamsinh = Sokhachhang.DS_KhachHang.Select(m => new { }).ToList();


            return View(Model);
        }
        //LIST AND LINQ


    }
}