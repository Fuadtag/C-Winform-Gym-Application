using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApplication.Models
{
    class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber{ get; set; }
        public int? PackageId { get; set; }
        public byte PackageEntryQuantity{ get; set; }
        public Package package { get; set; }
        public List<MenuOrder> orders{ get; set; }
        public List<Payment> payments{ get; set; }
        public decimal Balance{ get; set; }
        public bool Status { get; set; }
    }
}
