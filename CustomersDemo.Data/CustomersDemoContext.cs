using CustomersDemo.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomersDemo.Data
{
    public class CustomersDemoContext : DbContext
    {
        public CustomersDemoContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}

