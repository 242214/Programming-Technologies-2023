using Data.API;
namespace Service.Implementation;

internal class Buy : IBuy
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public int UserId { get; set; }

    public Buy(int Id, int ProductId, int Amount)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
        this.UserId = 0;
    }
}