using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBartender.Models
{
    public class order
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
    }

    public class OrderDBContext : DbContext
    {
        public DbSet<Menu> Menu { get; set; }

        public System.Data.Entity.DbSet<MvcBartender.Models.order> orders { get; set; }
    }
}