﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MDK11Entities : DbContext
    {
        public MDK11Entities()
            : base("name=MDK11Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActiveWish> ActiveWish { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Washer> Washer { get; set; }
    }
}