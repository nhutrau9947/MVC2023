using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pratice.Entity
{
    public class mapKhachhang
    {
        KhachHangEntities db = new KhachHangEntities();

        public Taikhoan Timkiem(string user,string pass)
        {
            var login = db.Taikhoan.Where(m => m.Username == user & m.Pass == pass).ToList();
            if(login.Count>0)
            {
                return login[0];
            }
            else
            {
                return null;
            }
        }
    }
}