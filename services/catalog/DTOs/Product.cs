using System;
using System.Collections.Generic;

namespace Catalog.DTOs
{
    public class Product
    {
       public int Id { get; set; }
       public String Name { get; set; }
       public String Description { get; set; }
       public double UnitPrice { get; set; }
       public int CategoryId { get; set; }
       public Category Category { get; set; }
    }
}
