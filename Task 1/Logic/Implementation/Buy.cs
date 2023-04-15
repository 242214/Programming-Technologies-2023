using System;
using Data.API;
using Data.Implementation;
using Logic.API;
namespace Logic.Implementation;

internal class Buy : IBuy {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public uint Amount { get; set; }
    public int UserId { get; set; }

    public Buy(int Id, int ProductId, uint Amount)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
        this.UserId = 0;
    }
}