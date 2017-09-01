using System;
using System.Data.Entity;

namespace MvcBartender.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
    }

    public class MenuDBContext : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
    }
}