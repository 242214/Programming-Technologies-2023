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
        public void CheckAddingDeletingCustomer()
        {
            var database = IDataRepository.CreateDatabase();
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
/*
        [TestMethod]
        public void CheckAddingDeletingOrder()
        {
            var database = IDataRepository.CreateDatabase();
            ISell sell1 = new Sell(1, 1, 2, 1);
            database.AddOrder(sell1);
            Assert.AreEqual(database.CountOrderList(), 1);
            try
            {
                ISell sell2 = new Sell(1, 4, 2, 1);
                database.AddOrder(sell2);
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
            var database = IDataRepository.CreateDatabase();
            database.AddProduct(1, "Red Apple", 0.5);
            Assert.AreEqual(database.CountProductList(), 1);
            try
            {
                database.AddProduct(1, "Bread", 2.5);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add product with the same id.");
            }
            Assert.AreEqual(database.CountProductList(), 1);
            database.DeleteProduct(1);
            Assert.AreEqual(database.CountProductList(), 0);
        }
         [TestMethod]
        public void CheckAddingDeletingState()
        { 
            var database = IDataRepository.CreateDatabase();
            database.AddState(1, 1, 1, true);
            Assert.AreEqual(database.CountStateList(), 1);
            try
            {
                database.AddState(1, 1, 1, false);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add state with the same id");
            }
            Assert.AreEqual(database.CountStateList(), 1);
            database.DeleteState(1);
            Assert.AreEqual(database.CountStateList(), 0);
        }
*/
    }
}