using Data.Implementation;

namespace Data.API;

public abstract class IDatabase
{
    public abstract int CountCustomerList();
    public abstract int CountOrderList();
    public abstract int CountProductList();
    public abstract void AddCustomer(int Id, string FirstName, string LastName);
    public abstract ICustomer GetCustomer(int Id);
    public abstract void DeleteCustomer(int Id);
    public abstract void AddOrder(int Id, int ProductId, uint Amount);
    public abstract IOrder GetOrder(int Id);
    public abstract void DeleteOrder(int Id);
    public abstract void AddProduct(int Id, string Name, double Price, uint Amount);
    public abstract IProduct GetProduct(int Id);
    public abstract void DeleteProduct(int Id);
    public abstract List<IProduct> GetProductList();

    public static IDatabase CreateDatabase()
    {
        return new Database();
    }
}