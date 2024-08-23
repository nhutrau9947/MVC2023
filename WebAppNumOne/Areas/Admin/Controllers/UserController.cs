using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using WebAppNumOne.App_Start;


namespace WebAppNumOne.Areas.Admin.Controllers
{
    
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Login()
        {
            ViewBag.title = "Đăng nhập"; 
            return View();      
        }
        [HttpPost]
        public ActionResult Login(string username, string passwork)
        {

           
            mapTaiKhoan map = new mapTaiKhoan();
            var user = map.TimKiem(username, passwork);

            // Có thì sang trang Admin
            if (user != null)
            {
                // su dung session
                Session1.SetUser(user);



                //Cach 1
                //return RedirectToAction("Index","Dashboard", new { area="Admin"}); 
                //Cach 2
                return Redirect("/Admin/Dashboard/Index");
            }

            // khônng thì quay lại trang login báo 
            ViewBag.error = "Tên đăng nhập bị sai";

            return View();
        }
        // Session Logout

        public ActionResult Logout()
        {
            Session1.SetUser(null);
            return Redirect("/Admin/Dashboard/Index");
        }



        // them moi vao database

         // b1 tao form nguoi dung
         public ActionResult Dangky()
        {
            return View();
        }
        // b2 tao request de xu ly va add vao database
        [HttpPost]
        public ActionResult Dangky(Taikhoan model) // parameter se la thong so giong o form html(b1) => de gon thi su dung model 
        {
            mapTaiKhoan map = new mapTaiKhoan();
            if(map.ThemMoi(model) == true)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }
        }
    }
}