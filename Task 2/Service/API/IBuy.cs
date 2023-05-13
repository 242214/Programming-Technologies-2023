namespace Service.API;
public interface IBuy : IOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public uint Amount { get; set; }
    public int UserId { get; set; }
    
    Task AddAsync();
}