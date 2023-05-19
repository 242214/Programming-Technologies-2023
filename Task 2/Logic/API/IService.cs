using Service.Implementation;
using Data.API;
using Data.Implementation;

namespace Service.API;

public abstract class IService
{
    //public static IService Create() => new DataService(IDataRepository.CreateDatabase());

    public abstract Task<IEnumerable<ICustomer>> GetAllCustomers();
    public abstract Task AddCustomerAsync(ICustomer c);
    public abstract Task DeleteCustomerAsync(int id);

    public abstract Task<IEnumerable<IProduct>> GetAllProducts();
    public abstract Task AddProductAsync(int id, string name, double price);
    public abstract Task DeleteProductAsync(int id);

    //public abstract Task<IEnumerable<IOrder>> GetAllOrders();
    public abstract Task AddOrderAsync(IOrder c);
    public abstract Task DeleteOrderAsync(int id);

    public abstract Task AddStateAsync(IState s);
    public abstract Task DeleteStateAsync(int id);

    // Task AddSell(ISell s);
    // Task DeleteSell(int id);

    // Task AddBuy(IBuy b);
    // Task DeleteBuy(int id);
    public static IService Create()
    {
        return new DataService();
    }
}