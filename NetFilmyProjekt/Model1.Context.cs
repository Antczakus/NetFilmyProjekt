﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetFilmyProjekt
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class filmdbEntities : DbContext
    {
        public filmdbEntities()
            : base("name=filmdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aktor> Aktor { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Gatunek> Gatunek { get; set; }
        public virtual DbSet<Kraj> Kraj { get; set; }
        public virtual DbSet<Rezyser> Rezyser { get; set; }
    }
}
