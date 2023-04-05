using Data.API;
namespace Data.Implementation;

internal class Database : IDataRepository
{
    public Database() { }


    public override int CountCustomerList()
    {
        return CustomerList.Count();
    }
    public override int CountOrderList()
    {
        return OrderList.Count();
    }
    public override int CountProductList()
    {
        return ProductList.Count();
    }
    
    public override IState GetState(int Id)
    {
        return StateList(Id);
    }

    public override int CountStateList()
    {
        return StateList.Count();
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
        StateList.Add(s);
    }

    public override void DeleteState(int Id)
    {
        for(int i = 0; i < CountStateList(); i++)
        {
            if(GetState(i).Id == Id)
            {
                StateList.RemoveAt(i);
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
        CustomerList.Add(a);
    }
    public override ICustomer GetCustomer(int Id)
    {
        return CustomerList[Id];
    }
    public override void DeleteCustomer(int Id)
    {
        for (int i = 0; i < CountCustomerList(); i++)
        {
            if (GetCustomer(i).Id == Id)
            {
                CustomerList.RemoveAt(i);
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
        OrderList.Add(o);
    }
    public override IOrder GetOrder(int Id)
    {
        return OrderList[Id];
    }
    public override void DeleteOrder(int Id)
    {
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == Id)
            {
                OrderList.RemoveAt(i);
            }
        }
    }

    public override void AddProduct(int Id, string Name, double Price, uint Amount)
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
    public override IProduct GetProduct(int Id)
    {
        return ProductList[Id];
    }
    public override List<IProduct> GetProductList()
    {
        return ProductList;
    }
    public override void DeleteProduct(int Id)
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
