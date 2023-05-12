namespace Service.API;

public interface IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    Task AddAsync();
    Task DeleteAsync();
}