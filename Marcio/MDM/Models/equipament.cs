//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipament
    {
        public long id { get; set; }
        public Nullable<int> idequipamenttype { get; set; }
        public string description { get; set; }
        public string code { get; set; }
    
        public virtual equipamenttype equipamenttype { get; set; }
    }
}
