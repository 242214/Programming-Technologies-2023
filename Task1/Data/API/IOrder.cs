namespace Data.API;

public interface IOrder {
    public int Id { get; set; };
    public int ProductId { get; set; };
    public int Amount { get; set; };
}