﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mvcProjectEntities1 : DbContext
    {
        public mvcProjectEntities1()
            : base("name=mvcProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adminstrator> Adminstrators { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<orderProduct> orderProducts { get; set; }
        public virtual DbSet<orderTbl> orderTbls { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<userTbl> userTbls { get; set; }
    }
}
