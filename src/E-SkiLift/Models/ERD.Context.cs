﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_SkiLift.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERDContainer : DbContext
    {
        public ERDContainer()
            : base("name=ERDContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ticket> TicketSet { get; set; }
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<TicketTariff> TicketTariffSet { get; set; }
        public virtual DbSet<LiftTariff> LiftTariffSet { get; set; }
        public virtual DbSet<SkiLift> SkiLiftSet { get; set; }
        public virtual DbSet<SkiLiftSchedule> SkiLiftScheduleSet { get; set; }
        public virtual DbSet<LiftUsageHistory> LiftUsageHistorySet { get; set; }
    }
}
