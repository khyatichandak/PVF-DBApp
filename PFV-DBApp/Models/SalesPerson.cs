//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesPerson
    {
        public int SalesPersonID { get; set; }
        public string SalesPersonName { get; set; }
        public decimal SalesPersonPhone { get; set; }
        public string SalesPersonEmailID { get; set; }
        public int TerritoryID { get; set; }
    
        public virtual SalesPerson SalesPerson1 { get; set; }
        public virtual SalesPerson SalesPerson2 { get; set; }
        public virtual Territory Territory { get; set; }
    }
}