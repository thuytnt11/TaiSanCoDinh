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
    
    public partial class PHONGQUANTRI
    {
        public PHONGQUANTRI()
        {
            this.PHIEUGIAO = new HashSet<PHIEUGIAO>();
            this.THIETBI = new HashSet<THIETBI>();
        }
    
        public int maphongquantri { get; set; }
        public string tenphongquantri { get; set; }
    
        public virtual ICollection<PHIEUGIAO> PHIEUGIAO { get; set; }
        public virtual ICollection<THIETBI> THIETBI { get; set; }
    }
}