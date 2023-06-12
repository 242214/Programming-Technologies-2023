using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Presentation.Model.API
{
    public abstract class IServiceModel
    {
        public abstract Task<IEnumerable<Data.API.ICustomer>> GetAllCustomers();
        public abstract Task<IEnumerable<Data.API.IProduct>> GetAllProducts();
        public abstract Task AddCustomerAsync(int id, string firstName, string lastName);
        public abstract Task AddOrderAsync(int id, int productId, int buy, int sell, int userId);
        public abstract Task AddProductAsync(int id, string name, double price);
        public abstract Task AddStateAsync(int id, int productId, int amount, bool isAvailable);
        public abstract Task DeleteCustomerAsync(int id);
        public abstract Task DeleteOrderAsync(int id);
        public abstract Task DeleteProductAsync(int id);
        public abstract Task DeleteStateAsync(int id);
        public IServiceModel() { }
    }
}
