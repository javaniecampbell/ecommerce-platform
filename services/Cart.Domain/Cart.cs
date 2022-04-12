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
        public int ItemsCount { get; set; }

        public int CartQuantity
        {
            get
            {
                //TODO: Count the total here
                if (_products != null)
                {
                    return 0;
                }
                return 0;

            }
        }

        public void AddProduct(Product product)
        {
            var found = _products.FirstOrDefault(p => p.Id.Equals(product.Id));
            if (found == null)
            {
                _products.Add(product);
                ItemsCount++;
            }
            else
            {
                found.Quantity += product.Quantity;
                //_products.Remove(product);
                //_products.Add(found);
            }

        }
        // SOFTWARE DESIGN PRINCIPLES - OOP
        // SINGLE RESPONSIBILITY PRINCIPLE - Only do one thing and one well
        // NOT SAME AS SINGLETON DESIGN PATTERNS

        //TODO: Implement using TDD-First these features listed 
        //TODO: Increase Quantity
        //TODO: Decrease Quantity
        //TODO: Calculate the Total Cost of Items in Cart
        //TODO: Checkout
        //TODO: Remove an Item from Cart regardless of th quantity
        //TODO: Add an Item to cart
        //TODO: Same item added should only ncrease the quantity of the same item
        //TODO: When an items quantity goes below zero it should remove the item from the cart
    }
}
