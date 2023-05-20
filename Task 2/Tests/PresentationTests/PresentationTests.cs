using Presentation.ViewModel;
using Service.API;
using NSubstitute;

namespace PresentationTests
{
    public class PresentationTests
    {
        // private readonly BookInfoViewModel CatalogViewModel;

        // private readonly UsersViewModel UsersViewModel;

        private readonly ProductViewModel StateViewModel;

        // private readonly ICatalog Catalog;

        private readonly ICustomer Customer;

        private readonly IState State;
        public PresentationTests()
        {
            //Catalog = Substitute.For<ICatalog>();
            //CatalogViewModel = new BookInfoViewModel(Catalog);
            Customer = Substitute.For<ICustomer>();
            CustomerViewModel = new CustomerViewModel(Customer);
            State = Substitute.For<IState>();
            StateViewModel = new ProductViewModel(State);
        }

        [TestMethod]
        public async void AddCustomerTest()
        {
            await CustomerViewModel.AddCustomerCommand.ExecuteAsync(null);
            await Customer.Received(1).AddAsync();
        }

        [TestMethod]
        public async void DeleteCustomerTest()
        {
            await CustomerViewModel.DeleteCustomerCommand.ExecuteAsync(null);
            await Customer.Received(1).DeleteAsync();
        }
    }
}