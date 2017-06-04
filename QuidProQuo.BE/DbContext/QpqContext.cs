using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuidProQuo.BE.Models
{
    public class QpqContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Thing> Things { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<ThingOrder> ThingOrders { get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<OrderBase> OrderBase { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryItem>()
                .HasMany(x => x.Subcategories);
            modelBuilder.Entity<Account>()
                .HasRequired(c => c.Profile)
                .WithRequiredPrincipal(c => c.Account);

            base.OnModelCreating(modelBuilder);
        }
    }
}