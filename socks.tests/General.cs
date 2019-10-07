using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using socks.library;

namespace socks.tests
{
    [TestClass]
    public class General
    {
        [TestMethod]
        public void Count_Pairs()
        {
            // Arrange
            var inventory = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            // Act
            var output = Inventory.Socks(inventory);

            // Assert
            Assert.AreEqual(3, output);
        }
    }
}