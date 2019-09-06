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
    
    public partial class tblModelVersionFlag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblModelVersionFlag()
        {
            this.tblModelVersions = new HashSet<tblModelVersion>();
        }
    
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public int Model_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status_ID { get; set; }
        public Nullable<byte> CommittedOnly_ID { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public byte[] LastChgTS { get; set; }
    
        public virtual tblModel tblModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblModelVersion> tblModelVersions { get; set; }
    }
}
