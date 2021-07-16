using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public string Description { get; set; }
        public bool isShipped { get; set; }
        public bool hasArrived { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
