using Data.Implementation;
using System.Linq;

namespace Data.API
{
    public interface IDataContext
    {
    public IQueryable<ICustomer> Customer { get;}
    public IQueryable<IProduct> Product { get;}
    public IQueryable<IOrder> Order { get; }
    public IQueryable<IState> State { get; }

    public static IDataContext CreateContext(string? connectionString = null) => new DataContext(connectionString);
    Task AddCustomerAsync(ICustomer customer);
    Task AddStateAsync(IState state);
    Task AddProductAsync(IProduct product);
    Task AddOrderAsync(IOrder order);
    Task DeleteCustomerAsync(int Id);
    Task DeleteStateAsync(int Id);
    Task DeleteProductAsync(int Id);
    Task DeleteOrderAsync(int Id);
    }
}
