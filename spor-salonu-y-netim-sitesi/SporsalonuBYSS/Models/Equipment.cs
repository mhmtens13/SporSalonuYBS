//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SporsalonuBYSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        public int EquipmentID { get; set; }
        public int DealerID { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
    
        public virtual Dealer Dealer { get; set; }
    }
}
