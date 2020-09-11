using Ecommerce.Model;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//IdentityDbContext<ApplicationUser>
namespace Ecommerce.Domain.DBContext
{
    public class EcommerceDBContext: DbContext
    {
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }

        public DbSet<Admin> Administrators { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
