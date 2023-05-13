using Service.Implementation;
using Data.API;
namespace Service.API;

public interface IService
    {
    //public static IService Create() => new DataService(IDataContext.CreateContext());

    Task<IEnumerable<ICustomer>> GetAllCustomers();
    Task AddCustomer(ICustomer c);
    //Task DeleteCustomer(int id);

    Task<IEnumerable<IProduct>> GetAllProducts();
    Task AddCustomer(IProduct c);
    Task DeleteCustomer(int id);

    Task<IEnumerable<IOrder>> GetAllOrders();
    Task AddOrder(IOrder c);
    Task DeleteOrder(int id);

    Task AddState(IState s);
    Task DeleteState(int id);

    Task AddSell(ISell s);
    Task DeleteSell(int id);

    Task AddBuy(IBuy b);
    Task DeleteBuy(int id);
    }