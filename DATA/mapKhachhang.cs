using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;

namespace DATA
{
    public class mapKhachhang
    {

        public KhachHangEntities db = new KhachHangEntities();
        public string message;

        // Hàm lấy dữ liệu
        public List<Khachhang> LoadDanhSach()
        {
            // Lệnh kết nối
            //KhachHangEntities db = new KhachHangEntities();
            // Lấy danh sách từ bảng
            var danhSach = db.Khachhang.ToList();
            //var danhSach2 = db.Khachhang.Where(m => m.TenKhachHang == "abc").ToList();
            // Lấy một đối tượng

            //var doiTuong = db.Khachhang.Find();
            //var doiTuong1 = db.Khachhang.SingleOrDefault(m=>m.ID ==1);
            //var doiTuong2 = db.Khachhang.FirstOrDefault(m => m.ID == 1);
            return danhSach;
        }
        // cap nhat
        public Khachhang ChiTiet(int id)
        {
            return db.Khachhang.Find(id);
        }
        // Hàm update
        public bool CapNhat(Khachhang model)
        {
            var danhsachcapnhat = db.Khachhang.Find(model.ID);
            if(danhsachcapnhat == null)
            {
                message = "Khong tim thay doi tuong cap nhat";
                return false;
            }
            danhsachcapnhat.ID = model.ID;
            danhsachcapnhat.TenKhachHang = model.TenKhachHang;
            danhsachcapnhat.NgaySinh = model.NgaySinh;
            danhsachcapnhat.Diachi = model.Diachi;
            danhsachcapnhat.NamSinh = model.NamSinh;
            danhsachcapnhat.SoTien = model.SoTien;
            danhsachcapnhat.Active = model.Active;
            db.SaveChanges();
            return true;
        }


        public List<Khachhang> Phantrang(int page, int size)
        {
            //page = 1 => skip(0) => skip(page -1 )* size

            var Ds = db.Khachhang.ToList().Skip((page - 1) * size).Take(size).ToList();
            return Ds;
        
        }


        public List<NhanVien> LoadDanhSachNV()
        {
            var danhSach = db.NhanVien.ToList();
            return danhSach;
        }
        // Hàm thêm mới

        public int ThemMoi(Khachhang model)
        {
            try
            {
                db.Khachhang.Add(model);
                db.SaveChanges();
                return model.ID;
            }
            catch
            {
                return 0;
            }
            
        }
        // Hàm xóa
        public void Xoa(int ID)
        {
            var danhsachcapnhat = db.Khachhang.Find(ID);
            db.Khachhang.Remove(danhsachcapnhat);
            db.SaveChanges();

        }
    }
}