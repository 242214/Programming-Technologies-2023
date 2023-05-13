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
        private string sqlString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        [TestMethod]
        public void CheckAddingDeletingCustomer()
        {
            //var database = IDataRepository.CreateDatabase();
            DataRepository database = new DataRepository(sqlString);
            database.AddCustomer(1, "John", "John");
            //Assert.AreEqual("John", database.GetCustomer(1).FirstName);
            /*try
            {
                database.AddCustomer(1, "Kate", "Jonie");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add a customer with the same id.");
            }
            Assert.AreEqual(database.CountCustomerList(), 1);
            database.DeleteCustomer(1);
            Assert.AreEqual(database.CountCustomerList(), 0);*/
        }
        [TestMethod]
        public void CheckAddingDeletingOrder()
        {
            var database = IDataRepository.CreateDatabase();
            IOrder order1 = new Order(1, 1, 2, 1);
            database.AddOrder(order1);
            Assert.AreEqual(database.CountOrderList(), 1);
            try
            {
                IOrder order2 = new Order(1, 4, 2, 1);
                database.AddOrder(order2);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Trying to add an order with the same id.");
            }
            Assert.AreEqual(database.CountOrderList(), 1);
            database.DeleteOrder(1);
            Assert.AreEqual(database.CountOrderList(), 0);
        }
    // [TestMethod]
    // public void CheckAddingDeletingOrder()
    // {
    //     // Arrange
    //     IDataRepository dataRepo = DataRepository.CreateDatabase();
    //     IOrder order = new Order(1, 1, 3, 3);
    //     //int expectedOrderListCount = dataRepo.CountOrderList() + 1;

    //     // Act
    //     dataRepo.AddOrder(order);
    //     int actualOrderListCount = dataRepo.CountOrderList();
    //     dataRepo.DeleteOrder(0);
    //     int finalOrderListCount = dataRepo.CountOrderList();

    //     // Assert
    //     //Assert.AreEqual(expectedOrderListCount, actualOrderListCount);
    //     Assert.AreEqual(dataRepo.GetOrder(1), order);
    //     Assert.AreEqual(finalOrderListCount, 1);
    // }
    // [TestMethod]
    //     public void CheckAddingDeletingOrder()
    //     {
    //         IDataRepository _dataRepository = new DataRepository();
    //         // Arrange
    //         int orderId = 1;
    //         int productId = 2;
    //         uint amount = 10;
    //         int userId = 1;
    //         IOrder newOrder = new Order(orderId, productId, amount, userId);

    //         // Act
    //         _dataRepository.AddOrder(newOrder);

    //         // Assert
    //         Assert.AreEqual(1, _dataRepository.CountOrderList());
    //         Assert.AreEqual(newOrder, _dataRepository.GetOrder(orderId));

    //         // Arrange
    //         int newOrderId = 2;
    //         IOrder anotherOrder = new Order(newOrderId, productId, amount, userId);

    //         // Act
    //         _dataRepository.AddOrder(anotherOrder);

    //         // Assert
    //         Assert.AreEqual(2, _dataRepository.CountOrderList());
    //         Assert.AreEqual(anotherOrder, _dataRepository.GetOrder(newOrderId));
    //         Assert.AreNotEqual(newOrder, _dataRepository.GetOrder(newOrderId));

    //         // // Act & Assert
    //         // Assert.ThrowsException<InvalidOperationException>(() => _dataRepository.AddOrder(anotherOrder));

    //         // Act
    //         _dataRepository.DeleteOrder(orderId);

    //         // Assert
    //         Assert.AreEqual(1, _dataRepository.CountOrderList());
    //         Assert.IsNull(_dataRepository.GetOrder(orderId));

    //         // Act
    //         _dataRepository.DeleteOrder(newOrderId);

    //         // Assert
    //         Assert.AreEqual(0, _dataRepository.CountOrderList());
    //         Assert.IsNull(_dataRepository.GetOrder(newOrderId));
    //     }
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