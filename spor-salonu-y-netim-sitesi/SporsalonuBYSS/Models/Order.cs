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
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> MembersID { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public string ShippedAdress { get; set; }
        public string ShippedFirstName { get; set; }
        public string ShippedLastName { get; set; }
        public string ShippedPhone { get; set; }
        public string ShippedCity { get; set; }
        public string ShippedTown { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
