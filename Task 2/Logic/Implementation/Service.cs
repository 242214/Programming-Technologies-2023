using Data;
using Data.API;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ServiceTests")]

namespace Service.Implementation
{
    internal class DataService
    {
        private IDataRepository dataRepository;
         internal DataService(IDataRepository dataRepository)
         {
             this.dataRepository = dataRepository;
         }
        public IDataRepository GetDataRepository()
        {
            return dataRepository;
        }

        public async Task AddProductAsync(IProduct p)
        {
            await Task.Run(() =>
            {
                dataRepository.AddProduct(p.Id, p.Name, p.Price);
            });
        }

        public async Task AddStateAsync(IState s)
        {
            await Task.Run(() =>
            {
                dataRepository.AddState(s.Id, s.ProductId, s.Amount, s.isAvailable);
            });
        }

        public async Task AddCustomerAsync(ICustomer c)
        {            
            await Task.Run(() =>
            {
                dataRepository.AddCustomer(c.Id, c.FirstName, c.LastName);
            });
        }

        public async Task AddOrderAsync(IOrder o)
        {
            await Task.Run(() =>
            {
                dataRepository.AddOrder(o);
            });
        }        

        public async Task DeleteProductAsync(int id)
        {
            await Task.Run(() =>
            {
                dataRepository.DeleteProduct(id);
            });
        }

        public async Task DeleteStateAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteState(id);
            });
        }

        public async Task DeleteOrderAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteOrder(id);
            });
        }

        public async Task DeleteCustomerAsync(int id)
        {
             await Task.Run(() =>
            {
                dataRepository.DeleteCustomer(id);
            });
        }

         public async Task<IEnumerable<IProduct>> GetAllProducts()
         {
             return dataRepository.GetProductList.Select(p => new ProductModel(p.Id, p.Name, p.Price, this)).ToList();
         }
        // public async Task<IEnumerable<API.IUsers>> GetAllCustomers()
        // {
        //     return dataContext.Customers.Select(c => new CustomerModel(this, c.Id, c.FirstName, c.LastName)).ToList();
        // }

    }
}