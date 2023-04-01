namespace Data.API;
public interface IProduct 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public uint Amount { get; set; }
}