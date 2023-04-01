using Data.API;
namespace Data.Implementation;

public class Database : IDatabase
{
    List<ICustomer> CustomerList = new();
    List<IOrder> OrderList = new();
    List<IProduct> ProductList = new();

    public int CountCustomerList()
    {
        return CustomerList.Count();
    }
    public int CountOrderList()
    {
        return OrderList.Count();
    }
    public int CountProductList()
    {
        return ProductList.Count();
    }

    public void AddCustomer(int Id, string FirstName, string LastName)
    {
        ICustomer a = new Customer(Id, FirstName, LastName);
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        CustomerList.Add(a);
    }
    public ICustomer GetCustomer(int Id)
    {
        return CustomerList[Id];
    }
    public void DeleteCustomer(int Id)
    {
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                CustomerList.RemoveAt(i);
            }
        }
    }

    public void AddOrder(int Id, int ProductId, uint Amount)
    {
        IOrder o = new Order(Id, ProductId, Amount);
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        OrderList.Add(o);
    }
    public IOrder GetOrder(int Id)
    {
        return OrderList[Id];
    }
    public void DeleteOrder(int Id)
    {
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                OrderList.RemoveAt(i);
            }
        }
    }

    public void AddProduct(int Id, string Name, float Price, uint Amount)
    {
        IProduct p = new Product(Id, Name, Price, Amount);
        for (int i = 0; i < CountProductList(); i++)
        {
            if (GetProduct(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        ProductList.Add(p);
    }
    public IProduct GetProduct(int Id)
    {
        return ProductList[Id];
    }
    public void DeleteProduct(int Id)
    {
        for(int i = 0; i < CountProductList(); i++)
        {
            if(GetProduct(i).Id == Id)
            {
                ProductList.RemoveAt(i);
            }
        }
    }
}
