using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class MenuOrder
    {
        public int id{ get; set; }
        public int CustomerId{ get; set; }
        public Customer  customer{ get; set; }
        public int MenuItemId{ get; set; }
        public MenuItem menu{ get; set; }
        public int Quantity { get; set; }
        public List<MenuItem> menuItems{ get; set; }
        public bool Status { get; set; }
    }
}
