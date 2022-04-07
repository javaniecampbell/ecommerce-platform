using System;
using System.Collections.Generic;
using System.Linq;

namespace CartService.Domain
{
    public class Cart
    {
        public Cart()
        {
            _products = new List<Product>();
        }
        private IList<Product> _products;

        public IEnumerable<Product> Products { get { return _products; } }
        public int Quantity { get; set; }

        public void AddProduct(Product product)
        {
            var found = _products.FirstOrDefault(p => p.Id.Equals(product.Id));
            if (found == null)
            {
                _products.Add(product);
                Quantity++;
            }
            else
            {
                found.Quantity++;
                //_products.Remove(product);
                //_products.Add(found);
            }
            
        }
    }
}
