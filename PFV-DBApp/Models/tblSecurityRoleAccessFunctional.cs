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
    
    public partial class tblSecurityRoleAccessFunctional
    {
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public int Role_ID { get; set; }
        public byte FunctionalPrivilege_ID { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
    
        public virtual tblSecurityPrivilegeFunctional tblSecurityPrivilegeFunctional { get; set; }
        public virtual tblSecurityRole tblSecurityRole { get; set; }
    }
}
