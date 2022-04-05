using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Order
    {
        public Guid OrderId { get {
                             
                    return Guid.NewGuid();
            } }
        public Pizza Pizza { get; set; }
        public Customer Customer { get; set; }

    }
}
