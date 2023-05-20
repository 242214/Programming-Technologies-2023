using Presentation.ViewModel;
using Service.API;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PresentationTests
    {
        // private readonly BookInfoViewModel CatalogViewModel;

        // private readonly UsersViewModel UsersViewModel;
/*
        private readonly ProductViewModel StateViewModel;

        // private readonly ICatalog Catalog;

        private static readonly ICustomer Customer = Substitute.For<ICustomer>();
        private static readonly IState State = Substitute.For<IState>();
        CustomerViewModel cvm = new CustomerViewModel(Customer);
        StateViewModel svm = new StateViewModel(State);
*/
        /*[TestMethod]
        public async Task AddCustomerTest()
        {
            //await cvm.AddCustomerCommand.ExecuteAsync(null);
            //await Customer.Received(1).AddAsync();
        }

        [TestMethod]
        public async Task DeleteCustomerTest()
        {
            //await cvm.DeleteCustomerCommand.ExecuteAsync(null);
            //await Customer.Received(1).DeleteAsync();
        }
        */


        [TestMethod]
        public void ProductTest()
        {
            var productViewModel = new ProductViewModel(1, "apple", 3.5);
            Assert.AreEqual(1, productViewModel.Id);
            Assert.AreEqual("apple", productViewModel.Name);
            Assert.AreEqual(3.5, productViewModel.Price);
        }

    }
}