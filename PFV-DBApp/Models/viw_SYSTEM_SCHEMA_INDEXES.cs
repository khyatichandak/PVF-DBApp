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
    
    public partial class viw_SYSTEM_SCHEMA_INDEXES
    {
        public int Model_ID { get; set; }
        public System.Guid Model_MUID { get; set; }
        public string Model_Name { get; set; }
        public int Entity_ID { get; set; }
        public System.Guid Entity_MUID { get; set; }
        public string Entity_Name { get; set; }
        public int Index_ID { get; set; }
        public System.Guid Index_MUID { get; set; }
        public string Index_Name { get; set; }
        public Nullable<int> SysIndex_ID { get; set; }
        public bool Index_IsUnique { get; set; }
        public int EnteredUser_ID { get; set; }
        public Nullable<System.Guid> EnteredUser_MUID { get; set; }
        public string EnteredUser_UserName { get; set; }
        public System.DateTime EnteredUser_DTM { get; set; }
        public int LastChgUser_ID { get; set; }
        public Nullable<System.Guid> LastChgUser_MUID { get; set; }
        public string LastChgUser_UserName { get; set; }
        public System.DateTime LastChgUser_DTM { get; set; }
    }
}
