namespace Data.API;

public interface IOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Buy { get; set; }
    public int Sell { get; set; }
}