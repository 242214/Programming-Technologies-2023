using Data.API;
namespace Data.Implementation;

internal class DataContext : IDataContext
{
    internal List<ICustomer> CustomerList = new();
    internal List<IOrder> OrderList = new();
    internal List<IProduct> ProductList = new();
    internal List<IState> StateList = new();
}