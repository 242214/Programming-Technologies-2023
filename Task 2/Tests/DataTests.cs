using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Data.API;
using Data.Implementation;
using Logic.Implementation;
using System.Data.SqlTypes;

namespace Tests
{
    [TestClass]
    public class CheckAddingObjects
    {
        private string sqlString = "Data Source=LAPTOP-5T8JC9IH;Initial Catalog=PTShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        [TestMethod]
        public void CheckAddingDeletingCustomer()
        {
            DataRepository database = new DataRepository(sqlString);
            database.AddCustomer(1, "John", "John");
            Assert.AreEqual("John", database.GetCustomer(1).FirstName);
            database.DeleteCustomer(1);
            Assert.AreEqual(database.CountCustomerList(), 0);
        }
        [TestMethod]
        public void CheckAddingDeletingOrder()
        {
            DataRepository database = new DataRepository(sqlString);
            IOrder order1 = new Order(1, 1, 2, 1);
            database.AddOrder(order1);
            Assert.AreEqual(1, database.GetOrder(1).ProductId);
            database.DeleteOrder(1);
            Assert.AreEqual(database.CountOrderList(), 0);
        }
        [TestMethod]
        public void CheckAddingDeletingProduct()
        {
            DataRepository database = new DataRepository(sqlString);
            database.AddProduct(1, "Red Apple", 0.5);
            Assert.AreEqual("Red Apple", database.GetProduct(1).Name);
            database.DeleteProduct(1);
            Assert.AreEqual(database.CountProductList(), 0);
        }
        [TestMethod]
       public void CheckAddingDeletingState()
       { 
           DataRepository database = new DataRepository(sqlString);
           database.AddState(1, 1, 1, true);
           Assert.AreEqual(true, database.GetState(1).isAvailable);
           database.DeleteState(1);
           Assert.AreEqual(database.CountStateList(), 0);
       }
    }
}