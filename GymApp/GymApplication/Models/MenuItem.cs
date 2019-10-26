using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class MenuItem
    {
        public int id { get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
