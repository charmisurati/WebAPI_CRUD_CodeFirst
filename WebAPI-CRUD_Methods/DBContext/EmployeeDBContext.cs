using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAPI_CRUD_Methods.Models;

namespace WebAPI_CRUD_Methods.DBContext
{
    public class EmployeeDBContext : DbContext
    {

        public EmployeeDBContext() : base("Employee") {                    
        }
        public DbSet <Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}