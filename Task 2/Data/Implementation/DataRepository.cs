using Data.API;
using Data.Implementation.DB;
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
    private IState Map(STATE state)
    {
        if (state == null)
        {
            return null;
        }
        return new State(state.Id, state.ProductId, state.Amount, state.isAvailable);
    }
    public override IState GetState(int Id)
    {
        //STATE state = dc.STATEs.Single(STATE => STATE.Id == Id);
        STATE state = new STATE();
        var v = from s in dc.STATEs
                    where s.Id == Id
                    select s;
        foreach (var item  in v) 
        {
            state.Id = item.Id;
            state.ProductId = item.ProductId;
            state.Amount = item.Amount;
            state.isAvailable = item.isAvailable;
        }
        return Map(state);
    }

    public override int CountStateList()
    {
        return datacontext.StateList.Count();
    }

    public override void AddState(int Id, int ProductId, int Amount, bool isAvailable)
    {
        STATE newState = new STATE
        {
            Id = Id,
            ProductId = ProductId,
            Amount = Amount,
            isAvailable = true
        };
        dc.STATEs.InsertOnSubmit(newState);
        dc.SubmitChanges();
    }

    public override void DeleteState(int Id)
    {
        STATE state = dc.STATEs.Single(STATE => STATE.Id == Id);
        dc.STATEs.DeleteOnSubmit(state);
        dc.SubmitChanges();
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
        //CUSTOMER customer = dc.CUSTOMERs.FirstOrDefault(c => c.Id.Equals(Id));
        CUSTOMER customer = new CUSTOMER();
        var v = from s in dc.CUSTOMERs
                where s.Id == Id
                select s;
        foreach (var item in v)
        {
            customer.Id = item.Id;
            customer.FirstName = item.FirstName;
            customer.LastName = item.LastName;
        }
        return Map(customer);
    }
    public override List<ICustomer> GetCustomerList()
    {
        List<ICustomer> customers = new List<ICustomer>();
        var v = from s in dc.CUSTOMERs select s;
        foreach (var item in v)
        {
            customers.Add(Map(item));
        }
        return customers;
    }
    public override void DeleteCustomer(int Id)
    {
        CUSTOMER customer = dc.CUSTOMERs.Single(CUSTOMER => CUSTOMER.Id == Id);
        dc.CUSTOMERs.DeleteOnSubmit(customer);
        dc.SubmitChanges();
    }
    public override int CountCustomerList()
    {
        return dc.CUSTOMERs.Count();
    }
    #endregion

    #region Order
    private IOrder Map(ORDER order)
    {
        if(order == null)
        {
            return null;
        }
        return new Order(order.Id, order.ProductId, order.Buy, order.Sell, order.UserId);
    }
    public override void AddOrder(int Id, int ProductId, int Buy, int Sell, int UserId)
    {
        ORDER newOrder = new ORDER
        {
            Id = Id, ProductId = ProductId, Buy = Buy, Sell = Sell,  UserId = UserId
        };
        dc.ORDERs.InsertOnSubmit(newOrder);
        dc.SubmitChanges();
    }
    public override IOrder GetOrder(int Id)
    {
        //ORDER order = dc.ORDERs.Single(ORDER => ORDER.Id == Id);
        ORDER order = new ORDER();
        var v = from s in dc.ORDERs
                where s.Id == Id
                select s;
        foreach (var item in v)
        {
            order.Id = item.Id;
            order.ProductId = item.ProductId;
            order.Buy = item.Buy;
            order.Sell = item.Sell;
            order.UserId = item.UserId;
        }
        return Map(order);
    }
    public override void DeleteOrder(int Id)
    {
        ORDER order = dc.ORDERs.Single(ORDER => ORDER.Id == Id);
        dc.ORDERs.DeleteOnSubmit(order);
        dc.SubmitChanges();
    }
    public override int CountOrderList()
    {
        return dc.ORDERs.Count();
    }
    #endregion

    #region Product
    private IProduct Map(PRODUCT product)
    {
        if (product == null)
        {
            return null;
        }
        return new Product(product.Id, product.Name, product.Price);
    }
    public override void AddProduct(int Id, string Name, double Price)
    {
        PRODUCT newProduct = new PRODUCT
        {
            Id = Id,
            Name = Name,
            Price = Price
        };
        dc.PRODUCTs.InsertOnSubmit(newProduct);
        dc.SubmitChanges();
    }
    public override IProduct GetProduct(int Id)
    {
        PRODUCT product = new PRODUCT();
        var v = from s in dc.PRODUCTs
                where s.Id == Id
                select s;
        foreach (var item in v)
        {
            product.Id = item.Id;
            product.Name = item.Name;
            product.Price = item.Price;
        }
        return Map(product);
    }
    public override List<IProduct> GetProductList()
    {
        List<IProduct > products = new List<IProduct>();
        var v = from s in dc.PRODUCTs select s;
        foreach(var item in v)
        {   
            products.Add(Map(item));
        }
        return products;
    }
    public override void DeleteProduct(int Id)
    {
        PRODUCT product = dc.PRODUCTs.Single(PRODUCT => PRODUCT.Id == Id);
        dc.PRODUCTs.DeleteOnSubmit(product);
        dc.SubmitChanges();
    }
    public override int CountProductList()
    {
        return dc.PRODUCTs.Count();
    }
    #endregion
}
