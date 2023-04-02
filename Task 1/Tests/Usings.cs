global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Implementation;
using Logic.Implementation;

namespace Tests
{
    [TestClass]
    public class TestBusinessLogic
    {
        [TestMethod]
        public void BuyProductTest()
        {

        }
        [TestMethod]
        public void SellProductTest() 
        {
            IBusinessLogic businessLogic = new();
            IDatabase database;
            businessLogic.SellProduct(5, 7, 4);
            try {
                businessLogic.SellProduct(1, 2, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Product Amount cannot be equal or less than 0");
            }
            try {

            }
            Assert.AreEqual(database.CountOrderList(), 1);
        }
    }
}