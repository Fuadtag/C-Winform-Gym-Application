using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GymApplication.Models;

namespace GymApplication.DAL
{
    class dbcontext :  DbContext
    {
        public dbcontext() : base("GymDatabase")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MenuItem> menuItems{ get; set; }
        public DbSet<MenuOrder> menuOrders { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<Payment> payments{ get; set; }


    }
    
}
