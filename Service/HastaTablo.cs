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
    
    public partial class HastaTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaTablo()
        {
            this.IslemTablo = new HashSet<IslemTablo>();
            this.RandevuTablo = new HashSet<RandevuTablo>();
        }
    
        public int HastaID { get; set; }
        public Nullable<int> HekimID { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string TC { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Durum { get; set; }
        public Nullable<int> Yas { get; set; }
        public string Cinsiyet { get; set; }
    
        public virtual HekimTablo HekimTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IslemTablo> IslemTablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandevuTablo> RandevuTablo { get; set; }
    }
}
