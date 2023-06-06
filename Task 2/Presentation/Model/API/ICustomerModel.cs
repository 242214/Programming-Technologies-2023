using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Presentation.Model.API
{
public interface ICustomerModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IServiceModel service {get; }

    public Task AddAsync();

    public Task DeleteAsync();
}
}