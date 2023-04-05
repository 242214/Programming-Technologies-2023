using Data.API;
namespace Data.Implementation;

internal class DataRepository : IDataRepository
{
    //public DataRepository() { }
    private readonly DataContext datacontext = new DataContext();

    public override int CountCustomerList()
    {
        return datacontext.CustomerList.Count();
    }
    public override int CountOrderList()
    {
        return datacontext.OrderList.Count();
    }
    public override int CountProductList()
    {
        return datacontext.ProductList.Count();
    }
    
    public override IState GetState(int Id)
    {
        return datacontext.StateList[Id];
    }

    public override int CountStateList()
    {
        return datacontext.StateList.Count();
    }

    public override void AddState(int Id, int ProductId, uint Amount, bool isAvailable)
    {
        IState s = new State(Id, ProductId, Amount, isAvailable);
        for (int i = 0; i < CountStateList(); i++)
        {
            if(GetState(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        datacontext.StateList.Add(s);
    }

    public override void DeleteState(int Id)
    {
        for(int i = 0; i < CountStateList(); i++)
        {
            if(GetState(i).Id == Id)
            {
                datacontext.StateList.RemoveAt(i);
            }
        }
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
        datacontext.CustomerList.Add(a);
    }
    public override ICustomer GetCustomer(int Id)
    {
        return datacontext.CustomerList[Id];
    }
    public override void DeleteCustomer(int Id)
    {
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                datacontext.CustomerList.RemoveAt(i);
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
        datacontext.OrderList.Add(o);
    }
    public override IOrder GetOrder(int Id)
    {
        return datacontext.OrderList[Id];
    }
    public override void DeleteOrder(int Id)
    {
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                datacontext.OrderList.RemoveAt(i);
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
        datacontext.ProductList.Add(p);
    }
    public override IProduct GetProduct(int Id)
    {
        return datacontext.ProductList[Id];
    }
    public override List<IProduct> GetProductList()
    {
        return datacontext.ProductList;
    }
    public override void DeleteProduct(int Id)
    {
        for(int i = 0; i < CountProductList(); i++)
        {
            if(GetProduct(i).Id == Id)
            {
                datacontext.ProductList.RemoveAt(i);
            }
        }
    }
}
