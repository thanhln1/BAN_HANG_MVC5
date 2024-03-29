﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAN_HANG_MVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
            this.ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }
    
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> LuotXem { get; set; }
        public Nullable<int> IdLoaiSanPham { get; set; }
        public Nullable<decimal> GiaKhuyenMai { get; set; }
        public string HinhAnh { get; set; }
        public string HinhAnh1 { get; set; }
        public string HinhAnh2 { get; set; }
        public Nullable<bool> DaXoa { get; set; }
        public Nullable<int> Moi { get; set; }
        public Nullable<int> IdMLSP { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual MaLoaiSanPham MaLoaiSanPham { get; set; }
    }
}
