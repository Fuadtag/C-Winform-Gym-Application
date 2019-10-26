using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Payment
    {
        public int id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int PackageId { get; set; }
        public Package  Package{ get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Amount{ get; set; }
        public bool Status { get; set; }

    }
}
