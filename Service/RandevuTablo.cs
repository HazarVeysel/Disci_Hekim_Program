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
    
    public partial class RandevuTablo
    {
        public int RandevuID { get; set; }
        public Nullable<int> HastaID { get; set; }
        public Nullable<int> HekimID { get; set; }
        public string RandevuTarih { get; set; }
        public string RandevuSaat { get; set; }
    
        public virtual HastaTablo HastaTablo { get; set; }
        public virtual HekimTablo HekimTablo { get; set; }
    }
}
