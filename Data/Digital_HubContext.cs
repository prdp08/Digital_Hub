using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Digital_Hub.Models;

namespace Digital_Hub.Data
{
    public class Digital_HubContext : DbContext
    {
        public Digital_HubContext (DbContextOptions<Digital_HubContext> options)
            : base(options)
        {
        }

        public DbSet<Digital_Hub.Models.Brand_Detail> Brand_Detail { get; set; }

        public DbSet<Digital_Hub.Models.Category_Detail> Category_Detail { get; set; }

        public DbSet<Digital_Hub.Models.Customer_Detail> Customer_Detail { get; set; }

        public DbSet<Digital_Hub.Models.Product_Detail> Product_Detail { get; set; }

        public DbSet<Digital_Hub.Models.Order_Detail> Order_Detail { get; set; }
    }
}
