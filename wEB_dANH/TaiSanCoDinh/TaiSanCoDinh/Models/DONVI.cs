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
    
    public partial class DONVI
    {
        public DONVI()
        {
            this.PHIEUGIAO = new HashSet<PHIEUGIAO>();
            this.PHIEUNHAP = new HashSet<PHIEUNHAP>();
        }
    
        public int madonvi { get; set; }
        public string tendonvi { get; set; }
        public string ghichu { get; set; }
    
        public virtual ICollection<PHIEUGIAO> PHIEUGIAO { get; set; }
        public virtual ICollection<PHIEUNHAP> PHIEUNHAP { get; set; }
    }
}
