using Service.Implementation;
using Data.API;
using Data.Implementation;

namespace Service.API;

public abstract class IService
{
    //public static IService Create() => new DataService(IDataRepository.CreateDatabase());

    public abstract Task<IEnumerable<Data.API.ICustomer>> GetAllCustomers();
    public abstract Task AddCustomerAsync(int Id, string FirstName, string LastName);
    public abstract Task DeleteCustomerAsync(int id);

    public abstract Task<IEnumerable<Data.API.IProduct>> GetAllProducts();
    public abstract Task AddProductAsync(int Id, string Name, double Price);
    public abstract Task DeleteProductAsync(int id);

    //public abstract Task<IEnumerable<IOrder>> GetAllOrders();
    public abstract Task AddOrderAsync(int Id, int ProductId, int Buy, int Sell, int UserId);
    public abstract Task DeleteOrderAsync(int id);

    public abstract Task AddStateAsync(int Id, int ProductId, int Amount, bool isAvailable);
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