using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
using Presentation.Model.API;
namespace Presentation.Model
{
internal class CustomerModel : ICustomerModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IServiceModel service {get; }
    public CustomerModel(IServiceModel service, int Id, string FirstName, string LastName)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.service = service;
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