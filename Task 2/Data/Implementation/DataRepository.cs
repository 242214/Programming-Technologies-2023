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
        STATE state = dc.STATEs.Single(STATE => STATE.Id == Id);
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
        CUSTOMER customer = dc.CUSTOMERs.FirstOrDefault(c => c.Id.Equals(Id));
        return Map(customer);
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
        return new Order(order.Id, order.ProductId, order.Amount, order.UserId);
    }
    public override void AddOrder(IOrder o)
    {
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
        PRODUCT product = dc.PRODUCTs.FirstOrDefault(c => c.Id.Equals(Id));
        return Map(product);
    }
    public override List<IProduct> GetProductList()
    {
        return datacontext.ProductList;
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
