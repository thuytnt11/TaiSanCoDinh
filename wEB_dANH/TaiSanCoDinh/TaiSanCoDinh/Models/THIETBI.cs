//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaiSanCoDinh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THIETBI
    {
        public THIETBI()
        {
            this.CHITIETPHIEUGIAO = new HashSet<CHITIETPHIEUGIAO>();
            this.PHIEUNHAP = new HashSet<PHIEUNHAP>();
        }
    
        public int mathietbi { get; set; }
        public string tenthietbi { get; set; }
        public Nullable<int> dongia { get; set; }
        public string thongsokythuat { get; set; }
        public Nullable<System.DateTime> ngaysanxuat { get; set; }
        public Nullable<System.DateTime> ngayduavaosudung { get; set; }
        public Nullable<System.DateTime> ngaycapnhat { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<int> madonvitinh { get; set; }
        public Nullable<int> maloai { get; set; }
        public Nullable<int> maphongquantri { get; set; }
        public Nullable<int> matinhtrang { get; set; }
    
        public virtual ICollection<CHITIETPHIEUGIAO> CHITIETPHIEUGIAO { get; set; }
        public virtual DONVITINH DONVITINH { get; set; }
        public virtual LOAITHIETBI LOAITHIETBI { get; set; }
        public virtual ICollection<PHIEUNHAP> PHIEUNHAP { get; set; }
        public virtual PHONGQUANTRI PHONGQUANTRI { get; set; }
        public virtual TINHTRANG TINHTRANG { get; set; }
    }
}
