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
    
    public partial class IslemDetayTablo
    {
        public int IslemDetayID { get; set; }
        public Nullable<int> IslemID { get; set; }
        public string İslemAdi { get; set; }
        public Nullable<double> BirimFiyat { get; set; }
        public Nullable<int> Adet { get; set; }
    
        public virtual IslemTablo IslemTablo { get; set; }
    }
}
