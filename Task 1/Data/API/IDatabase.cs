namespace Data.API;

public interface IDatabase
{
    public int CountCustomerList();
    public int CountOrderList();
    public int CountProductList();
    public void AddCustomer(int Id, string FirstName, string LastName);
    public ICustomer GetCustomer(int Id);
    public void DeleteCustomer(int Id);
    public void AddOrder(int Id, int ProductId, uint Amount);
    public IOrder GetOrder(int Id);
    public void DeleteOrder(int Id);
    public void AddProduct(int Id, string Name, double Price, uint Amount);
    public IProduct GetProduct(int Id);
    public void DeleteProduct(int Id);
}