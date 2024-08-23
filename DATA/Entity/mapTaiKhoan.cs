using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA.Entity
{
    public class mapTaiKhoan
    {
        KhachHangEntities db = new KhachHangEntities();

        // 1.Đăng nhập bằng user và passwork  
        public Taikhoan TimKiem(string username, string passwork)
        {
            var user = db.Taikhoan.Where(m => m.Username == username && m.Pass == passwork).ToList();
            if (user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }
        // 2. Lấy danh sách => trả về kiểu List
        public List<Taikhoan> Danhsach()
        {
            var user = db.Taikhoan.ToList();
            return user;
        }

        // 3. Them moi => phai co tokng tin them moi(tu form html(parameter))

        public void ThemMoi(int Id, string username, string passwork)
        {
            // tao va gan du lieu vao doi tuong
            Taikhoan tk = new Taikhoan();
            tk.Id = Id;
            tk.Username = username;
            tk.Pass = passwork;

            // Add vao list doi tuong trong dataset entity
            db.Taikhoan.Add(tk);

            // Luu vao database
            db.SaveChanges();

        }
        public bool ThemMoi(Taikhoan tk)
        {
            // tao va gan du lieu vao doi tuong ==> tao o trong contrller
            try { 
            // Add vao list doi tuong trong dataset entity
            db.Taikhoan.Add(tk);

            // Luu vao database
            db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
