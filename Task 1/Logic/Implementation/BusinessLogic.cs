using System;
using Data.API;
using Data.Implementation;
using Logic.API;
namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    IDataRepository database = IDataRepository.CreateDatabase();
    public BusinessLogic() { }

    public override void BuyProduct(int Id, uint Amount) //uzupełnij produkt
    {
        int a = 0;
        for (int i = 0; i < database.CountProductList(); i++)
        {
            if (database.GetProduct(i).Id == Id)
            {
                a = 1;
                //database.GetState(i).Amount = database.GetState(i).Amount + Amount;
                //if(database.GetState(i).Amount > 0) {}
            }
        }
        if(a==0) {
            throw new Exception("Product with this Id doesnt exist");
        }
    }
    public override void SellProduct(int Id, int ProductId, uint OrderAmount, int UserId) //sprzedaj klijentowi
    {
        if (OrderAmount <= 0) throw new Exception("Product Amount cannot be equal or less than 0");
        //if (database.GetProduct(ProductId).Amount < OrderAmount) throw new Exception("Not enough product");
        database.AddOrder(Id, ProductId, OrderAmount, UserId);
        //remove product from the shop
    }
}
//Lista do zrobienia
//- TestLogic nie powinnien używać "uing Data.Implementation" i "using Data.API" zamiast tego trzeba stworzyć clasę jak Data w Test
//- Przenieść Amount z Product do nowej classy State, która posiada też zmienną typu bool o nazwie Avaliable, jeśli product > 0 --> Avaliable = true, else Avaliable = false

