using System;
using Data.API;
using Data.Implementation;
using Logic.API;
namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    IDatabase database = IDatabase.CreateDatabase();
    public BusinessLogic() { }

    public override void BuyProduct(int Id, uint Amount)//uzupełnij produkt
    {
        int a = 0;
        for (int i = 0; i < database.CountProductList(); i++)
        {
            if (database.GetProduct(i).Id == Id)
            {
                a = 1;
                database.GetProduct(i).Amount = database.GetProduct(i).Amount + Amount;
            }
        }
        if(a==0) {
            throw new Exception("Product with this Id doesnt exist");
        }
    }
    public override void SellProduct(int Id, int ProductId, uint OrderAmount)//sprzedaj klijentowi
    {
        if (OrderAmount <= 0) throw new Exception("Product Amount cannot be equal or less than 0");
        if (database.GetProduct(ProductId).Amount < OrderAmount) throw new Exception("Not enough product");
        database.AddOrder(Id, ProductId, OrderAmount);
    }
}
