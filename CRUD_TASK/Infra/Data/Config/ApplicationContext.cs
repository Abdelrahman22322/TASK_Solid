using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Data;
using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace crud.Data.Config
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Customer?> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product?> Products { get; set; }
        public DbSet<Employee?> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .AddJsonFile("json1.json")
                .Build();
            var connectionString = config.GetSection("DefaultConnection").Value;
            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderItemConfig());
            // modelBuilder.ApplyConfiguration(new ProductConfig());
            // modelBuilder.ApplyConfiguration(new EmployeeConfig());

            // Seed Data Customer

            var customerdata = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\CRUD_TASK\\crud\\MOCK_DATA.json");
            var customers = JsonConvert.DeserializeObject<List<Customer>>(customerdata);

            foreach (var customer in customers)
            {
                modelBuilder.Entity<Customer>().HasData(customer);
            }

            //// Seed Data Employee
            //var employeedata = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\CRUD_TASK\\crud\\MOCK_DATA (3).json");
            //var employees = JsonConvert.DeserializeObject<List<Employee>>(employeedata);
            //foreach (var employee in employees)
            //{
            //    modelBuilder.Entity<Employee>().HasData(employee);
            //}
            //// Seed Data Order
            //var orderdata = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\CRUD_TASK\\crud\\MOCK_DATA (15).json");
            //var orders = JsonConvert.DeserializeObject<List<Order>>(orderdata);
            //foreach (var order in orders)
            //{
            //    modelBuilder.Entity<Order>().HasData(order);
            //}

            // Seed Data OrderItem
            var orderitemdata = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\CRUD_TASK\\crud\\MOCK_DATA (16).json");
            var orderitems = JsonConvert.DeserializeObject<List<OrderItem>>(orderitemdata);
            foreach (var orderitem in orderitems)
            {
                modelBuilder.Entity<OrderItem>().HasData(orderitem);
            }
            // Seed Data Product
            //var productdata = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\CRUD_TASK\\crud\\MOCK_DATA (17).json");
            //var products = JsonConvert.DeserializeObject<List<Product>>(productdata);
            //foreach (var product in products)
            //{
            //    modelBuilder.Entity<Product>().HasData(product);
            //}
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 10,
                    UnitPrice = 100
                },
                new OrderItem
                {
                    OrderId = 1,
                    ProductId = 2,
                    Quantity = 20,
                    UnitPrice = 200
                }
            );


        }
    }
}
