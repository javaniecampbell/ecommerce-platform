using CartService.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CartService.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void Products_List_Should_Not_Be_Empty()
        {
            // Arrange
            Cart sut = new Cart();

            // Act 
            sut.AddProduct(new Product { Id = Guid.NewGuid(), Name = "", Description = "", UnitPrice = 50d });
            sut.AddProduct(new Product { Id = Guid.NewGuid(), Name = "", Description = "", UnitPrice = 50d });


            // Assert
            Assert.IsNotNull(sut.Products);
        }
        [TestMethod]
        public void Should_Increase_TheQuantity_When_Add_A_Product()
        {
            // TDD
            // Red  -Green - Refactor
            // Red- Fail First
            // Green - Write just enough to make the test pass
            // Refactor - remove code smells, improve quality and make maintainable 
            // sut - system under test
            
            // Arrange
            Cart sut = new Cart();

            // Act 
            sut.AddProduct(new Product { Id = Guid.NewGuid(), Name = "", Description = "", UnitPrice = 50d });
            sut.AddProduct(new Product { Id = Guid.NewGuid(), Name = "", Description = "", UnitPrice = 50d });


            // Assert
            Assert.IsTrue(sut.ItemsCount == 2);

            // Start with writing test with the current
        }

        [TestMethod]
        public void Should_Have_One_Item_When_The_Same_Product_Is_Added()
        {
            // TDD
            // Red  -Green - Refactor
            // Red- Fail First
            // Green - Write just enough to make the test pass
            // Refactor - remove code smells, improve quality and make maintainable 
            // sut - system under test

            // Arrange
            Cart sut = new Cart();
            Guid id = Guid.NewGuid();
            // Act 
            sut.AddProduct(new Product { Id = id, Name = "", Description = "", UnitPrice = 50d, Quantity = 1 });
            sut.AddProduct(new Product { Id = id, Name = "", Description = "", UnitPrice = 50d, Quantity = 1 });


            // Assert
            Assert.IsTrue(sut.ItemsCount == 1);

            // Start with writing test with the current
        }
        [TestMethod]
        public void When_TheSame_Item_Is_Add_It_Should_Increase_The_Quantity_By_The_ItemBeingAdded_Quantity()
        {
            // Arrange
            Cart sut = new Cart();
            Guid id = Guid.NewGuid();
            // Act 
            sut.AddProduct(new Product { Id = id, Name = "", Description = "", UnitPrice = 50d, Quantity = 3 });
            sut.AddProduct(new Product { Id = id, Name = "", Description = "", UnitPrice = 50d, Quantity = 1 });

            // ItemCount does not increase if is the same item - unique items in cart
            // CartQuantity or TotalItemInCart increases - this all the quantities of each item reduced to a single value total
            // Assert
            Assert.IsTrue(sut.ItemsCount == 1);
            Assert.IsTrue(sut.CartQuantity == 4);
        }

    }
}
