﻿namespace Data.Implementation;
using Data.API;

public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public uint Amount { get; set; }

    public Product(int Id, string Name, float Price, uint Amount)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.Amount = Amount;
    }
}