namespace Data.Implementation;
using Data.API;

public class Customer
{
    public int Id { get; set; };
    public string FirstName { get; set; };
    public string LastName { get; set; };

    Customer(int Id, string FirstName, string LastName)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}