using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
using Data.API;
namespace Presentation.Model
{
public class CustomerModel : ICustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IService service {get; }
    public CustomerModel(IService service, int Id, string FirstName, string LastName)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    public async Task AddAsync()
    {
        await service.AddCustomerAsync(Id, FirstName, LastName);
    }

    public async Task DeleteAsync()
    {
        await service.DeleteCustomerAsync(this.Id);
    }
}
}