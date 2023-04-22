using Data.API;
namespace Logic.Implementation;

public class Sell : ISell
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public uint Amount { get; set; }
    public int UserId { get; set; }

    public Sell(int Id, int ProductId, uint Amount, int UserId)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
        this.UserId = UserId;
    }
}