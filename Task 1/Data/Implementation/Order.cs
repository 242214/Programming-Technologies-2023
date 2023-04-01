namespace Data.Implementation;
using Data.API;

public class Order : IOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public uint Amount { get; set; }

    public Order(int Id, int ProductId, uint Amount)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
    }
}