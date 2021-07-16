using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Models
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Address = "123 Mayberry Ln, Des Moines, IA 50310" },
                new Customer { CustomerId = 2, FirstName = "Tyler", LastName = "Hochstetler", Address = "432 S Berry Dr, Des Moines, IA 50312" }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Description = "First Order of the Day", isShipped = false, hasArrived = false, CustomerId = 1 }
            );
        }
    }
}
