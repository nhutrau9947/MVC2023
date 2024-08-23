using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppNumOne.Models
{
    public class KhachHang
    {
        public string HovaTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public int Namsinh { set; get; }
        public string  Diachi { set; get; }
        public string  Gioitinh { set; get; }
        public string  CCCD { set; get; }
        public string  SDT { set; get; }
        public string  Email { set; get; }
        public string  Facebook { set; get; }
        public string[] Chungchi { set; get; }
    }
}