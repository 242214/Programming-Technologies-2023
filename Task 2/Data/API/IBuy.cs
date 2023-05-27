namespace Data.API;
public interface IBuy : IOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Buy { get; set; }
    public int Sell { get; set; }
    public int UserId { get; set; }
}