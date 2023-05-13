using Data.API;
using System.Linq;
namespace Data.Implementation;

internal class DataRepository : IDataRepository
{
    //public DataRepository() { }
    //LinqToSqlDataContext dc = new LinqToSqlDataContext();
    private LinqToSqlDataContext dc;
    //public DataRepository()
    //{
    //    dc = new LinqToSqlDataContext();
    //}
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
        //IState s = new State(Id, ProductId, Amount, isAvailable);
        for (int i = 0; i < CountStateList(); i++)
        {
            if(GetState(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        //datacontext.StateList.Add(s);
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
        //ICustomer a = new Customer(Id, FirstName, LastName);
        //for (int i = 0; i < CountCustomerList(); i++)
        //{
        //    if (GetCustomer(i).Id == Id)
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}
        //datacontext.CustomerList.Add(a);
        CUSTOMER customerr = dc.CUSTOMERs.Single(CUSTOMER => CUSTOMER.Id == Id);
        if (customerr != null)
        {
            throw new InvalidOperationException();
        }
        CUSTOMER customer = new CUSTOMER();
        customer.Id = Id;
        customer.FirstName = FirstName;
        customer.LastName = LastName;
        dc.CUSTOMERs.InsertOnSubmit(customer);
        dc.SubmitChanges();
    }
    public override ICustomer GetCustomer(int Id)
    {
        CUSTOMER customer = dc.CUSTOMERs.Single(CUSTOMER => CUSTOMER.Id == Id);
        return (ICustomer)customer;
        //return datacontext.CustomerList[Id];
    }
    public override void DeleteCustomer(int Id)
    {
        //for (int i = 0; i < CountCustomerList(); i++)
        //{
        //    if (GetCustomer(i).Id == Id)
        //    {
        //        datacontext.CustomerList.RemoveAt(i);
        //    }
        //}
        CUSTOMER customer = dc.CUSTOMERs.Single(CUSTOMER => CUSTOMER.Id == Id);
        dc.CUSTOMERs.DeleteOnSubmit(customer);
        dc.SubmitChanges();
    }

    public override void AddOrder(IOrder o)
    {
        for (int i = 0; i < CountOrderList(); i++)
        {
            if (GetOrder(i).Id == o.Id)
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
        //IProduct p = new Product(Id, Name, Price);
        for (int i = 0; i < CountProductList(); i++)
        {
            if (GetProduct(i).Id == Id)
            {
                throw new InvalidOperationException();
            }
        }
        //datacontext.ProductList.Add(p);
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
