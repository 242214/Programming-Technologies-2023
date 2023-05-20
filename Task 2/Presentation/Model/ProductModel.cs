using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Service.API;
using Presentation.Model.API;
namespace Presentation.Model
{
    public class ProductModel : IProductModel
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public IService Servicee { get; }
    public ProductModel (int Id, string Name, double Price, IService service)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        Servicee = service;
    }

     public async Task AddAsync()
    {
        await Servicee.AddProductAsync(Id, Name, Price);
    }

    public async Task DeleteAsync()
    {
        await Servicee.DeleteProductAsync(this.Id);
    }
    }
}