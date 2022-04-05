using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Pizza
    {
        public string Size { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public Catogory Catogory { get; set; }

    }
}
