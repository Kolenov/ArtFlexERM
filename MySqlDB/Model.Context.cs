﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySqlDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<consumption> consumptions { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<job_titles> job_titles { get; set; }
        public virtual DbSet<material> materials { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<rest> rests { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<supply> supplies { get; set; }
        public virtual DbSet<unit> units { get; set; }
        public virtual DbSet<waybill> waybills { get; set; }
    }
}
