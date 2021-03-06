﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BackupSystemEntities : DbContext
    {
        public BackupSystemEntities()
            : base("name=BackupSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BackupItem> BackupItems { get; set; }
        public DbSet<BackupItemFileSystem> BackupItemFileSystems { get; set; }
        public DbSet<BackupItemFTP> BackupItemFTPs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobAdHoc> JobAdHocs { get; set; }
        public DbSet<JobAdHocDate> JobAdHocDates { get; set; }
        public DbSet<JobBackupItem> JobBackupItems { get; set; }
        public DbSet<JobScheduled> JobScheduleds { get; set; }
        public DbSet<JobScheduledExceptionDate> JobScheduledExceptionDates { get; set; }
        public DbSet<ActiveLicense> ActiveLicenses { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
