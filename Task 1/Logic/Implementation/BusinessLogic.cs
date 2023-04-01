using System;
using Data.API;
using Data.Implementation;
using Logic.API;
namespace Logic.Implementation;

public abstract class BusinessLogic : IBusinessLogic
{
    private IDatabase database = new Database();

    public override void BuyProduct(int Id, uint Amount)//uzupełnij produkt
    {
        for (int i = 0; i < database.CountProductList(); i++)
        {
            if (database.GetProduct(i).Id == Id)
            {
                database.GetProduct(i).Amount = database.GetProduct(i).Amount + Amount;
            }
        }
    }
    public override void SellProduct(int Id, int ProductId, uint OrderAmount)//sprzedaj klijentowi
    {
        if (OrderAmount <= 0) throw new Exception("Product Amount cannot be equal or less than 0");
        if (database.GetProduct(ProductId).Amount < OrderAmount) throw new Exception("Not enough product");
        database.AddOrder(Id, ProductId, OrderAmount);
    }
}
