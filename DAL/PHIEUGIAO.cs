//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUGIAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUGIAO()
        {
            this.CHITIETPHIEUGIAOs = new HashSet<CHITIETPHIEUGIAO>();
        }
    
        public int maphieugiao { get; set; }
        public Nullable<System.DateTime> ngaygiao { get; set; }
        public Nullable<int> daky { get; set; }
        public string tinhtrang { get; set; }
        public Nullable<int> maphongquantri { get; set; }
        public Nullable<int> madonvi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUGIAO> CHITIETPHIEUGIAOs { get; set; }
        public virtual DONVI DONVI { get; set; }
        public virtual PHONGQUANTRI PHONGQUANTRI { get; set; }
    }
}
