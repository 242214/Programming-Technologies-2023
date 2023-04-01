using Data.API;
using Data.Implementation;
using Logic.API;
namespace Logic.Implementation;

public class Class1
{
    public void BuyProduct(int Id, int Amount)
    {

    }
    public void SellProduct(int Id, int OrderAmount)//sprzedaj klijentowi
    {
        //if (IProduct < OrderAmount) throw new Exeption("Not enough product");
        if (OrderAmount <= 0) throw new Exception("Product Amount cannot be equal or lesser than 0");
        //IOrder sell = new Order(0, Id, O);

    }
}
