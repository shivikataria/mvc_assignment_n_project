﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rezercontrols.EDM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class project_workEntities1 : DbContext
    {
        public project_workEntities1()
            : base("name=project_workEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN_TABLE> ADMIN_TABLE { get; set; }
        public virtual DbSet<appointment_table> appointment_table { get; set; }
        public virtual DbSet<city_table> city_table { get; set; }
        public virtual DbSet<doctors_table> doctors_table { get; set; }
        public virtual DbSet<hospital_TABLE> hospital_TABLE { get; set; }
        public virtual DbSet<patient_TABLE> patient_TABLE { get; set; }
        public virtual DbSet<state_table> state_table { get; set; }
    }
}