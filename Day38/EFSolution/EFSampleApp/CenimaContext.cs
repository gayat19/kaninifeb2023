using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleApp
{
    public class CenimaContext:DbContext
    {
        public CenimaContext()
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbCenimas17Apr2023");
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(p => p.Rating).IsRequired(false);
  
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 101, Name = "Abc", Rating = 4.5f },
                new Movie { Id = 102, Name = "XYZ", Rating = 4.8f }
                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Ramu", Age = 22, Phone = "1234567890" }
                );
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingNumber=1000,ShowDate=DateTime.Now,MovieId=101,CustomerId=1}
                );
        }
    }
}
