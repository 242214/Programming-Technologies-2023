using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
namespace Presentation.Model.API
{
public interface IServiceModel : Service.API.IService
{
    public abstract class IServiceModel
{
    public abstract Task<IEnumerable<Data.API.ICustomer>> GetAllCustomers();
    public abstract Task AddCustomerAsync(int Id, string FirstName, string LastName);
    public abstract Task DeleteCustomerAsync(int id);

    public abstract Task<IEnumerable<Data.API.IProduct>> GetAllProducts();
    public abstract Task AddProductAsync(int Id, string Name, double Price);
    public abstract Task DeleteProductAsync(int id);
    public abstract Task AddOrderAsync(int Id, int ProductId, int Buy, int Sell, int UserId);
    public abstract Task DeleteOrderAsync(int id);

    public abstract Task AddStateAsync(int Id, int ProductId, int Amount, bool isAvailable);
    public abstract Task DeleteStateAsync(int id);
    public static IServiceModel Create()
    {
        return new DataService();
    }
}
}
}