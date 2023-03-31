namespace Data.Implementation;
using Data.API;

public class Order {
    public int Id;
    public int ProductId;
    public int Amount;

    Order (int Id, int ProductId, int Amount){
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
    }
}