using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
namespace Presentation.Model.API
{
public interface ICustomerModel : Service.API.ICustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IService service {get; }

    public Task AddAsync();

    public Task DeleteAsync();
}
}