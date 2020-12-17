using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplicationDemo.Model
{
    public class MyDBContext : DbContext
    {
        protected MyDBContext()
        {
        }

        public MyDBContext([NotNull] DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlite("Data Source=./sqlite_demo.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity => {
                entity.ToTable("person");
                entity.Property(e => e.Id)
                    .UseIdentityColumn();
            });
        }
    }
}
