﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTicket.EFModels
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRVCinemaEntities : DbContext
    {
        public CRVCinemaEntities()
            : base("name=CRVCinemaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<FoodDrinks> FoodDrinks { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<OrderedItems> OrderedItems { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<IdentityUserRole> UserRoles { get; set; }
        public virtual DbSet<Shows> Shows { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTokens> UserTokens { get; set; }
    }
}
