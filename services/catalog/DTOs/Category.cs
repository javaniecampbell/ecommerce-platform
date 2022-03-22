using System;

namespace Catalog.DTOs
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public bool IsActive { get; set; }

        // public IList<Product> Products { get; set; }

    }
}
