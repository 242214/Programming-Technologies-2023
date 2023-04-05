namespace Data.Implementation;
using Data.API;

internal class Order : IOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public uint Amount { get; set; }
    public int UserId { get; set; }

    public Order(int Id, int ProductId, uint Amount, int UserId)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
        this.UserId = UserId;
    }
}