using Data.API;
namespace Service.Implementation;

public class Selling : ISell
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Buy { get; set; }
    public int Sell { get; set; }
    public int UserId { get; set; }

    public Selling(int Id, int ProductId, int Sell, int UserId)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Buy = 0;
        this.Sell = Sell;
        this.UserId = UserId;
    }
}