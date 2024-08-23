using NhanVienDATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVienDATA
{
    public class DATANV
    {
        KhachHangEntities dbNV = new KhachHangEntities();

        public List<NhanVien> LoadDSnhanvien()
        {
            var DSnhanvien = dbNV.NhanVien.ToList();
            return DSnhanvien;
        }
        public NhanVien GetChiTiet(int id)
        {
            var doiTuong = dbNV.NhanVien.Find(id);
            return doiTuong;
        }
    }
}
