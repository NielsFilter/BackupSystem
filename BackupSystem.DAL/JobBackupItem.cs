//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackupSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobBackupItem
    {
        public long JobID { get; set; }
        public long BackupItemID { get; set; }
        public string BackupTypeCode { get; set; }
    
        public virtual BackupItem BackupItem { get; set; }
        public virtual Job Job { get; set; }
    }
}
