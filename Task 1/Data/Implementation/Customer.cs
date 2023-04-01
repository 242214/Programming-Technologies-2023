//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
namespace Data.Implementation;
using Data.API;

public class Customer : ICustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(int Id, string FirstName, string LastName)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}