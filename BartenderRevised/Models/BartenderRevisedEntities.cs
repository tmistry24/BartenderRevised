using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderRevised.Models
{
    public class BartenderRevisedEntities : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}