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
    }
}