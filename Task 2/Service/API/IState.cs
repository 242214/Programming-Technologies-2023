namespace Service.API;

public interface IState
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public bool isAvailable { get; set; }

    Task AddAsync();
    Task DeleteAsync();
}