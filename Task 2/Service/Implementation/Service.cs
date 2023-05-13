using Data.API;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ServiceTests")]

namespace Service.Implementation
{
    internal class DataService
    {
        private IDataContext dataContext;

        internal DataService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task AddProduct(API.IProduct p)
        {
            await dataContext.AddProductAsync(new Product(p.Id, p.Name, p.Price));
        }

        public async Task AddState(API.IState s)
        {
            await dataContext.AddStateAsync(new State(

                s.Id, s.ProductId, s.Amount, s.isAvailable
                //dataContext.Products.Where(s => s.Id == s.ProductId).First()

            ));
        }

        public async Task AddCustomer(API.ICustomer c)
        {
            await dataContext.AddCustomerAsync(new Customer(c.Id, c.FirstName, c.LastName));
        }

        public async Task AddOrder(API.IOrder o)
        {
            await dataContext.AddOrderAsync(new Order(o.Id, o.ProductId, o.Amount, o.UserId));
        }        

        public Task DeleteProduct(int id)
        {
            return dataContext.DeleteProductAsync(id);
        }

        public Task DeleteState(int id)
        {
            return dataContext.DeleteStateAsync(id);
        }

        public Task DeleteOrder(int id)
        {
            return dataContext.DeleteOrderAsync(id);
        }

        public Task DeleteCustomer(int id)
        {
            return dataContext.DeleteCustomerAsync(id);
        }

        // public async Task<IEnumerable<API.IProduct>> GetAllProducts()
        // {
        //     return dataContext.Products.Select(p => new ProductModel(p.Id, p.Name, p.Price, this)).ToList();
        // }
        // public async Task<IEnumerable<API.IUsers>> GetAllCustomers()
        // {
        //     return dataContext.Customers.Select(c => new CustomerModel(this, c.Id, c.FirstName, c.LastName)).ToList();
        // }

    }
}