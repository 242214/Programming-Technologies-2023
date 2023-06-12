using Presentation.ViewModel;
using Presentation.Model.API;
using Service.API;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PresentationTests
    {
        public class MockCustomer : ICustomerModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public IServiceModel service { get; }
            public MockCustomer(IServiceModel service, int Id, string FirstName, string LastName)
            {
                this.Id = Id;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.service = service;
            }
            public MockCustomer() { }
            public Task AddAsync()
            {
                return Task.CompletedTask;
            }

            public Task DeleteAsync()
            {
                return Task.CompletedTask;
            }
        }

        public class AnotherMockCustomer : ICustomerModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public IServiceModel service { get; }
            public AnotherMockCustomer(IServiceModel service, int Id, string FirstName, string LastName)
            {
                this.Id = Id;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.service = service;
            }
            public AnotherMockCustomer() { }
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
            var customerViewModel = new CustomerViewModel((ICustomerModel)mockCustomer);

            customerViewModel.Name = "John Doe";

            Assert.AreEqual("John Doe", customerViewModel.Name);
        }

        [TestMethod]
        public void TestCustomerViewModelWithAnotherMockCustomer()
        {
            var anotherMockCustomer = new AnotherMockCustomer();
            var customerViewModel = new CustomerViewModel((ICustomerModel)anotherMockCustomer);

            customerViewModel.Name = "Jane Smith";

            Assert.AreEqual("Jane Smith", customerViewModel.Name);
        }
    }
}