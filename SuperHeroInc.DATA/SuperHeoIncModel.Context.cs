﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperHeroInc.DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SuperHeroIncEntities : DbContext
    {
        public SuperHeroIncEntities()
            : base("name=SuperHeroIncEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alignment> Alignments { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
