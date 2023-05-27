using Data.API;
namespace Service.Implementation;

internal class Buying : IBuy
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Buy { get; set; }
    public int Sell { get; set; }
    public int UserId { get; set; }

    public Buying(int Id, int ProductId, int Buy)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Buy = Buy;
        this.Sell = 0;
        this.UserId = 0;
    }
}