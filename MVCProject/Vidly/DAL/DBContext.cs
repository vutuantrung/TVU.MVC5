using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DAL
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base( ConfigurationManager.ConnectionStrings[ "vidlyConnectionString" ].ConnectionString )
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}