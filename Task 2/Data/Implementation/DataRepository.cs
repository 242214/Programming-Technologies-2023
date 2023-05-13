using Data.API;
using System.Linq;
namespace Data.Implementation;

public class DataRepository : IDataRepository
{
    private LinqToSqlDataContext dc;
    public DataRepository()
    {

    }
    public DataRepository(string sqlString)
    {
        dc = new LinqToSqlDataContext(sqlString);
    }
    //do usunięcia później
    private readonly DataContext datacontext = new DataContext();
    //
    #region State
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
    #endregion

    #region Customer
    private ICustomer Map(CUSTOMER customer)
    {
        if(customer == null)
        {
            return null;
        }
        return new Customer(customer.Id, customer.FirstName, customer.LastName);
    }
    public override void AddCustomer(int Id, string FirstName, string LastName)
    {
        //CUSTOMER customerr = dc.CUSTOMERs?.Single(CUSTOMER => CUSTOMER.Id == Id);
        //if (Map(customerr) != null)
        //{
        //    throw new InvalidOperationException();
        //}
        CUSTOMER newCustomer = new CUSTOMER
        {
            Id = Id,
            FirstName = FirstName,
            LastName = LastName
        };
        dc.CUSTOMERs.InsertOnSubmit(newCustomer);
        dc.SubmitChanges();
    }
    public override ICustomer GetCustomer(int Id)
    {
        CUSTOMER customer = dc.CUSTOMERs.FirstOrDefault(c => c.Id.Equals(Id));
        return Map(customer);
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
    public override int CountCustomerList()
    {
        return datacontext.CustomerList.Count();
    }
    #endregion

    #region Order
    public override void AddOrder(IOrder o)
    {
        ORDER order = dc.ORDERs.Single(ORDER => ORDER.Id == o.Id);
        if (order != null)
        {
            throw new InvalidOperationException();
        }
        ORDER newOrder = new ORDER
        {
            Id = o.Id, ProductId = o.ProductId, Amount = o.Amount,  UserId = o.UserId
        };
        dc.ORDERs.InsertOnSubmit(newOrder);
        dc.SubmitChanges();
    }
    public override IOrder GetOrder(int Id)
    {
        ORDER order = dc.ORDERs.Single(ORDER => ORDER.Id == Id);
        return (IOrder)order;

        //return datacontext.OrderList[Id];
    }
    public override void DeleteOrder(int Id)
    {
        // for (int i = 0; i < CountOrderList(); i++)
        // {
        //     if (GetOrder(i).Id == Id)
        //     {
        //         datacontext.OrderList.RemoveAt(i);
        //     }
        // }
        ORDER order = dc.ORDERs.Single(ORDER => ORDER.Id == Id);
        dc.ORDERs.DeleteOnSubmit(order);
        dc.SubmitChanges();
    }
    public override int CountOrderList()
    {
        return datacontext.OrderList.Count();
    }
    #endregion

    #region Product
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
    public override int CountProductList()
    {
        return datacontext.ProductList.Count();
    }
    #endregion
}
