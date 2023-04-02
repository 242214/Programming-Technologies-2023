using Data.API;
namespace Data.Implementation;

internal class Database : IDatabase
{
    List<ICustomer> CustomerList = new();
    List<IOrder> OrderList = new();
    List<IProduct> ProductList = new();

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

    public override void AddOrder(int Id, int ProductId, uint Amount)
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
