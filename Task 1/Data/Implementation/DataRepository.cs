using Data.API;
namespace Data.Implementation;

internal class DataRepository : IDataRepository
{

    public DataRepository() { }
    private readonly DataContext dataContext = new DataContext();


    public override int CountCustomerList()
    {
        return dataContext.CustomerList.Count();
    }
    public override int CountOrderList()
    {
        return dataContext.OrderList.Count();
    }
    public override int CountProductList()
    {
        return dataContext.ProductList.Count();
    }

    public override void AddCustomer(int Id, string FirstName, string LastName)
    {
        ICustomer a = new Customer(Id, FirstName, LastName);
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        dataContext.CustomerList.Add(a);
    }
    public override ICustomer GetCustomer(int Id)
    {
        return dataContext.CustomerList[Id];
    }
    public override void DeleteCustomer(int Id)
    {
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                dataContext.CustomerList.RemoveAt(i);
            }
        }
    }

    public override void AddOrder(int Id, int ProductId, uint Amount, int UserId)
    {
        IOrder o = new Order(Id, ProductId, Amount, UserId);
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        dataContext.OrderList.Add(o);
    }
    public override IOrder GetOrder(int Id)
    {
        return dataContext.OrderList[Id];
    }
    public override void DeleteOrder(int Id)
    {
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                dataContext.OrderList.RemoveAt(i);
            }
        }
    }

    public override void AddProduct(int Id, string Name, double Price)
    {
        IProduct p = new Product(Id, Name, Price);
        for (int i = 0; i < CountProductList(); i++)
        {
            if (GetProduct(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        dataContext.ProductList.Add(p);
    }
    public override IProduct GetProduct(int Id)
    {
        return dataContext.ProductList[Id];
    }
    public override List<IProduct> GetProductList()
    {
        return dataContext.ProductList;
    }
    public override void DeleteProduct(int Id)
    {
        for(int i = 0; i < CountProductList(); i++)
        {
            if(GetProduct(i).Id == Id)
            {
                dataContext.ProductList.RemoveAt(i);
            }
        }
    }
}
