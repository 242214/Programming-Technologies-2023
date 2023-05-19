global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Data.API;
using Data.Implementation;
using Service.API;
using Service.Implementation;
namespace Tests
{
    [TestClass]
    public class TestService
    {
        private static string sqlString = "Data Source=LAPTOP-5T8JC9IH;Initial Catalog=PTShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private static IDataRepository dataRepository= new DataRepository(sqlString);
        private DataService s = new DataService(dataRepository);
        [TestMethod]
        public void TestProductAsync()
        {
            s.AddProductAsync(7, "Potato", 2.5);
            var a = s.GetAllProducts();
            Assert.IsNotNull(s.GetAllProducts());
            s.DeleteProductAsync(7);
            Assert.AreNotEqual(a, s.GetAllProducts());
        }
        
        [TestMethod]
        public void AddCustomerAsyncTest()
        {
            s.AddCustomerAsync(7, "John", "John");
            Assert.IsNotNull(s.GetAllCustomers());
            var a = s.GetAllCustomers();
            s.DeleteCustomerAsync(7);
            Assert.AreNotEqual(a, s.GetAllCustomers());
        }
    }
}