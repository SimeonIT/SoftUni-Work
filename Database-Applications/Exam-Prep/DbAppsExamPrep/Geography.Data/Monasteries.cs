//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geography.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monasteries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
    
        public virtual Countries Countries { get; set; }
    }
}
