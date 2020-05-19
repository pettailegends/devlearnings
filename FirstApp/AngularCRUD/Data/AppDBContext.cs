using AngularCRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Quote> Courses { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quote");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");            
        }
    }
}
