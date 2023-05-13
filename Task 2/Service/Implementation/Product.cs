using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Service.API;
using Data.API;

namespace Service.Implementation
{
    internal class Product : IProduct
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product (int Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }

    // public Task AddAsync()
    // {
    //     throw new NotImplementedException();
    // }

    // public Task DeleteAsync()
    // {
    //     throw new NotImplementedException();
    // }
    }
}