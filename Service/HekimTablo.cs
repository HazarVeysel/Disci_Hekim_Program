//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class HekimTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HekimTablo()
        {
            this.HastaTablo = new HashSet<HastaTablo>();
            this.IslemTablo = new HashSet<IslemTablo>();
            this.RandevuTablo = new HashSet<RandevuTablo>();
        }
    
        public int HekimID { get; set; }
        public Nullable<int> AdminID { get; set; }
        public string HekimAdi { get; set; }
        public string HekimSoyad { get; set; }
    
        public virtual AdminTablo AdminTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaTablo> HastaTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IslemTablo> IslemTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandevuTablo> RandevuTablo { get; set; }
    }
}
