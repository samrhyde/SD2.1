using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HydeMvcP1.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object
namespace HydeMvcP1.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
   HydeMvcP1.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<orderDetail> OrderDetails { get; set; }
        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}