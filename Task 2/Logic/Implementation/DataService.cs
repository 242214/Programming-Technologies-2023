using Data;
using Data.API;
using Service.API;
using System.Drawing;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ServiceTests")]

namespace Service.Implementation
{
    public class DataService : IService
    {
        private IDataRepository dataRepository;
        public DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public DataService()
        {

        }

        public IDataRepository GetDataRepository()
        {
            return dataRepository;
        }

        #region Add
        public async override Task AddProductAsync(int Id, string Name, double Price)
        {
            await Task.Run(() =>
            {
                dataRepository.AddProduct(Id, Name, Price);
            });
        }
        public async override Task AddStateAsync(int Id, int ProductId, int Amount, bool isAvailable)
        {
            await Task.Run(() =>
            {
                dataRepository.AddState(Id, ProductId, Amount, isAvailable);
            });
        }
        public async override Task AddCustomerAsync(int Id, string FirstName, string LastName)
        {            
            await Task.Run(() =>
            {
                dataRepository.AddCustomer(Id, FirstName, LastName);
            });
        }
        public async override Task AddOrderAsync(int Id, int ProductId, int Buy, int Sell, int UserId)
        {
            await Task.Run(() =>
            {
                dataRepository.AddOrder(Id, ProductId, Buy, Sell, UserId);
            });
        }
        #endregion

        #region Delete
        public async override Task DeleteProductAsync(int id)
        {
            await Task.Run(() =>
            {
                dataRepository.DeleteProduct(id);
            });
        }

        public async override Task DeleteStateAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteState(id);
            });
        }

        public async override Task DeleteOrderAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteOrder(id);
            });
        }

        public async override Task DeleteCustomerAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteCustomer(id);
            });
        }
        #endregion

        #region Get All
        public async override Task<IEnumerable<Data.API.IProduct>> GetAllProducts()
         {
            return dataRepository.GetProductList();
             //return dataRepository.GetProductList.Select(p => new ProductModel(p.Id, p.Name, p.Price, this)).ToList();
         }
         public async override Task<IEnumerable<Data.API.ICustomer>> GetAllCustomers()
         {
            return dataRepository.GetCustomerList();
             //return dataContext.Customers.Select(c => new CustomerModel(this, c.Id, c.FirstName, c.LastName)).ToList();
         }
        #endregion
    }
}