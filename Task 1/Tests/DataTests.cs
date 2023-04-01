using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Data.API;
using Data.Implementation;
using Logic.Implementation;

namespace Tests
{
    [TestClass]
    public class CheckAddingObjects
    {
        [TestMethod]
        public void CheckAddinggCustomer()
        {
            IDatabase database = new Database();
            database.AddCustomer(1, "John", "John");
            Assert.AreEqual(database.CountCustomerList(), 1);
            try
            {
                database.AddCustomer(1, "Kate", "Jonie");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add a customer with the same id.");
            }
            Assert.AreEqual(database.CountCustomerList(), 1);
            database.DeleteCustomer(1);
            Assert.AreEqual(database.CountCustomerList(), 0);
        }

        [TestMethod]
        public void CheckAddingDeletingOrder()
        {
            IDatabase database = new Database();
            database.AddOrder(1, 1, 2);
            Assert.AreEqual(database.CountOrderList(), 1);
            try
            {
                database.AddOrder(1, 4, 2);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add an ordern order with the same id.");
            }
            Assert.AreEqual(database.CountOrderList(), 1);
            database.DeleteOrder(1);
            Assert.AreEqual(database.CountOrderList(), 0);
        }

        [TestMethod]
        public void CheckAddingDeletingProduct()
        {
            IDatabase database = new Database();
            database.AddProduct(1, "Red Apple", 0.5, 100);
            Assert.AreEqual(database.CountProductList(), 1);
            try
            {
                database.AddProduct(1, "Bread", 2.5, 500);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add product with the same id.");
            }
            Assert.AreEqual(database.CountProductList(), 1);
            database.DeleteProduct(1);
            Assert.AreEqual(database.CountProductList(), 0);
        }
    }
}