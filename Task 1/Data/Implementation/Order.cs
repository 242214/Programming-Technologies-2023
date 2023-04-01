namespace Data.Implementation;
using Data.API;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }

    Order(int Id, int ProductId, int Amount)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
    }
}