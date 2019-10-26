using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Package
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int EntryQuantity { get; set; }
        public List<Customer> customers { get; set; }
        
        public bool Status { get; set; }

    }
}
