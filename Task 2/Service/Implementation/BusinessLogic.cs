using System;
using Data.API;
using Data.Implementation;
using Service.API;
namespace Service.Implementation;

internal class BusinessLogic : IBusinessLogic
{ 
    IDataRepository database = IDataRepository.CreateDatabase();
    public BusinessLogic() { }

    public override void BuyProduct(int Id, int ProductId, int Amount) //uzupełnij produkt
    {
        int a = 0;
        for (int i = 0; i < database.CountProductList(); i++)
        {
            if (database.GetState(i).ProductId == ProductId)
            {
                a = 1;
                database.GetState(i).Amount = database.GetState(i).Amount + Amount;
                if(database.GetState(i).Amount > 0) database.GetState(i).isAvailable = true;
                IBuy buy = new Buy(Id, ProductId, Amount);
                database.AddOrder(buy);
            }
        }
        if(a==0) {
            throw new Exception("Product with this Id doesnt exist");
        }
    }
    public override void SellProduct(int Id, int ProductId, int OrderAmount, int UserId) //sprzedaj klijentowi
    {
        if (OrderAmount <= 0) throw new Exception("Product Amount cannot be equal or less than 0");
        if (!database.GetState(ProductId).isAvailable) throw new Exception("Not enough product");
        ISell sell = new Sell(Id, ProductId, OrderAmount, UserId);
        database.AddOrder(sell);
        database.GetState(ProductId).Amount = database.GetState(ProductId).Amount - OrderAmount;
        if (database.GetState(ProductId).Amount > 0) database.GetState(ProductId).isAvailable = true;
        else database.GetState(ProductId).isAvailable = false;
    }
}

