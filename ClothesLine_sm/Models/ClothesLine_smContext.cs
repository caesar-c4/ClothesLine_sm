using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClothesLine_sm.Models
{
    public class ClothesLine_smContext:DbContext
    {
        public ClothesLine_smContext() : base("ClothesLine_sm")
        {

        }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}