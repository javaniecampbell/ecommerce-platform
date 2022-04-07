using System;
using System.Collections.Generic;

namespace CartService.Domain
{
    public class Product
    {
       public Guid Id { get; set; }
       public String Name { get; set; }
       public String Description { get; set; }
       public double UnitPrice { get; set; }
       public int CategoryId { get; set; }
        public int Quantity { get; set; }
    }
}
