using Presentation.ViewModel;
using Service.API;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PresentationTests
    {
        // [TestMethod]
        // public void ProductTest()
        // {
        //     var productViewModel = new ProductViewModel(1, "apple", 3.5);
        //     Assert.AreEqual(1, productViewModel.Id);
        //     Assert.AreEqual("apple", productViewModel.Name);
        //     Assert.AreEqual(3.5, productViewModel.Price);
        // }
        [TestMethod]
        public void TestCustomerViewModelWithMockCustomer()
        {
            var mockCustomer = new MockCustomer();
            var customerViewModel = new CustomerViewModel(mockCustomer);

            customerViewModel.Name = "John Doe";

            Assert.Equal("John Doe", customerViewModel.Name);
        }

        [TestMethod]
        public void TestCustomerViewModelWithAnotherMockCustomer()
        {
            var anotherMockCustomer = new AnotherMockCustomer();
            var customerViewModel = new CustomerViewModel(anotherMockCustomer);

            customerViewModel.Name = "Jane Smith";

            Assert.Equal("Jane Smith", customerViewModel.Name);
        }

    }
}