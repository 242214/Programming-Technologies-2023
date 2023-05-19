global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Data.API;
using Data.Implementation;
using Service.API;
//using NSubstitute;
using Service.Implementation;
namespace Tests
{
    [TestClass]
    public class TestService
    {
         private string sqlString = "Data Source=LAPTOP-5T8JC9IH;Initial Catalog=PTShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        // private IDataRepository dataRepository;
        // private IDataContext dataContext;
        //private IDataContext dataContext;

        [TestMethod]
        public void TestProductAsync()
        {
            IDataRepository dataRepository= new DataRepository(sqlString);
            DataService s = new DataService(dataRepository);
            s.AddProductAsync(1, "Potato", 2.5);
            //Assert.AreEqual(dataRepository.GetProduct(1), s.GetAllProducts());
            Assert.IsNotNull(s.GetAllProducts());
            s.DeleteProductAsync(1);

        }
        


        [TestMethod]
        public void TestStateAsync() 
        {
            // dataContext = DataContext.CreateContext(sqlString);
            // dataRepository = new DataRepository(dataContext);
            // IState state = new State() { Id = 1, ProductId = 100, Amount = 5, IsAvailable = true };
            // await dataRepository.AddStateAsync(state);
            // IState retrievedState = await GetStateByIdAsync(state.Id);
            // Assert.IsNotNull(retrievedState);
            // Assert.AreEqual(state.ProductId, retrievedState.ProductId);
            // Assert.AreEqual(state.Amount, retrievedState.Amount);
            // Assert.AreEqual(state.IsAvailable, retrievedState.IsAvailable);
            // IState addedState = dataRepository.GetState(Id);
            // Assert.IsNotNull(addedState, "State should have been added to the data repository.");
            // Assert.AreEqual(state.ProductId, addedState.ProductId, "Product ID of the added state is incorrect.");
            // Assert.AreEqual(state.Amount, addedState.Amount, "Amount of the added state is incorrect.");
            // Assert.AreEqual(state.IsAvailable, addedState.IsAvailable, "Availability of the added state is incorrect.");
        }
        [TestMethod]
        public async Task AddCustomerAsyncTest()
        {
            IDataRepository dataRepository = new DataRepository();
            DataService dataService = new DataService(dataRepository);
            ICustomer customer = new Customer(1, "John", "Doe");
            await dataService.AddCustomerAsync(customer);
            IEnumerable<ICustomer> customers = await dataService.GetAllCustomers();
            bool customerAdded = false;
            foreach (ICustomer c in customers)
            {
                if (c.Id == customer.Id && c.FirstName == customer.FirstName && c.LastName == customer.LastName)
                {
                    customerAdded = true;
                    break;
                }
            }

            Assert.IsTrue(customerAdded);
        }

        // private IService service;
        // private IDataRepository dataRepository;

        // public TestService()
        // {
        //     dataRepository = Substitute.For<IDataRepository>();
        //     service = new DataService(dataRepository);
        // }

        // [TestMethod]
        // public async Task AddCustomer()
        // {
        //     ICustomer customer = new CustomerModel(1, "Will", "Smith", service);
        //     await service.AddCustomer(customer);
        //     await dataRepository.Received(1).AddCustomerAsync(Arg.Is<Data.ICustomer>(customer => customer.Id == 1)) ; 

        // }
    }
}