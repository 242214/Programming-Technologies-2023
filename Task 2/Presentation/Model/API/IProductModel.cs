using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
namespace Presentation.Model.API
{
    public interface IProductModel : Service.API.IProduct
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public IService Servicee { get; }

    public Task AddAsync();
    public Task DeleteAsync();
    }
}