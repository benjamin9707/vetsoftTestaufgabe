using System;
using Microsoft.EntityFrameworkCore;
using vetsoftTestaufgabe.Models;

namespace vetsoftTestaufgabe.DataProviders
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }
    }
}
