//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Khachhang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Diachi { get; set; }
        public Nullable<int> NamSinh { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
