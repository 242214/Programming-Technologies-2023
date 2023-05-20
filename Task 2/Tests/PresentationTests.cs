using Presentation.ViewModel;
using Service.API;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PresentationTests
    {
        public class MockCustomer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Task AddAsync()
        {
            return Task.CompletedTask;
        }

        public Task DeleteAsync()
        {
            return Task.CompletedTask;
        }
    }

    public class AnotherMockCustomer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Task AddAsync()
        {
            return Task.CompletedTask;
        }

        public Task DeleteAsync()
        {
            return Task.CompletedTask;
        }
    }

   
        [TestMethod]
        public void TestCustomerViewModelWithMockCustomer()
        {
            var mockCustomer = new MockCustomer();
            var customerViewModel = new CustomerViewModel(mockCustomer);

            customerViewModel.Name = "John Doe";

            Assert.AreEqual("John Doe", customerViewModel.Name);
        }

        [TestMethod]
        public void TestCustomerViewModelWithAnotherMockCustomer()
        {
            var anotherMockCustomer = new AnotherMockCustomer();
            var customerViewModel = new CustomerViewModel(anotherMockCustomer);

            customerViewModel.Name = "Jane Smith";

            Assert.AreEqual("Jane Smith", customerViewModel.Name);
        }
    
        // [TestMethod]
        // public void ProductTest()
        // {
        //     var productViewModel = new ProductViewModel(1, "apple", 3.5);
        //     Assert.AreEqual(1, productViewModel.Id);
        //     Assert.AreEqual("apple", productViewModel.Name);
        //     Assert.AreEqual(3.5, productViewModel.Price);
        // }
        /*[TestMethod]
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
        [TestMethod]
        public void teast()
        {
            var CustomerViewModel = new CustomerViewModel(6, "testName", "testLastName");

            var updateCommand = UserItemViewModel.UpdateCommand;

            UserItemViewModel.FirstName = null;
            UserItemViewModel.LastName = null;

            bool canBeExecuted = UserItemViewModel.CanUpdate;

            Assert.IsFalse(updateCommand.CanExecute(canBeExecuted));
        }*/
    }
}