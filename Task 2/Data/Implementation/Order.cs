using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }

        public Order(int Id, int ProductId, int Buy, int Sell, int UserId)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.UserId = UserId;
        this.Buy = Buy;
        this.Sell = Sell;
    }
    }
    
}