using Data.Implementation;

namespace Data.API;

public abstract class IDataRepository
{
    public abstract int CountCustomerList();
    public abstract int CountOrderList();
    public abstract int CountProductList();
    public abstract void AddCustomer(int Id, string FirstName, string LastName);
    public abstract ICustomer GetCustomer(int Id);
    public abstract void DeleteCustomer(int Id);
    public abstract void AddOrder(IOrder o);
    public abstract IOrder GetOrder(int Id);
    public abstract void DeleteOrder(int Id);
    public abstract void AddProduct(int Id, string Name, double Price);
    public abstract IProduct GetProduct(int Id);
    public abstract void DeleteProduct(int Id);
    public abstract List<IProduct> GetProductList();
    public abstract IState GetState(int Id);
    public abstract int CountStateList();
    public abstract void AddState(int Id, int ProductId, int Amount, bool isAvailable);
    public abstract void DeleteState(int Id);

    public static IDataRepository CreateDatabase()
    {
        return new DataRepository();
    }
}