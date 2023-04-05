global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.API;
using Data.Implementation;
using Logic.API;
using Logic.Implementation;
//od poprawy dodaj data test, nie u¿ywaj "using Data"
namespace Tests
{
    [TestClass]
    public class TestBusinessLogic
    {
        [TestMethod]
        public void BuyProductTest()
        {
            var businessLogic = IBusinessLogic.CreateBusinessLogic();
            try
            {
                businessLogic.BuyProduct(3, 3);
            }
            catch
            {
                Console.WriteLine("Product with this Id doesnt exist");
            }
        }
        [TestMethod]
        public void SellProductTest() 
        {
            var businessLogic = IBusinessLogic.CreateBusinessLogic();
            try {
                businessLogic.SellProduct(1, 2, 0, 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Product Amount cannot be equal or less than 0");
            }
            try {
                businessLogic.SellProduct(5, 7, 4, 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Not enough product");
            }
        }
    }
}