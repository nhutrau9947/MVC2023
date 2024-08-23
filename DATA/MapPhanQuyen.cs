using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class MapPhanQuyen
    {
        KhachHangEntities db = new KhachHangEntities();
        public string message = "";

        public bool KiemTra(int IdTaiKhoan, string MaChucNang)
        {
            // dem trong bang phan quyen lon hon 0 return true
            var dem = db.PhanQuyen.Count(m => m.IdTaiKhoan == IdTaiKhoan & m.MaChucNang == MaChucNang);

            if (dem > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
