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
        public int Amount { get; set; }
        public int UserId { get; set; }

        public Order(int Id, int ProductId, int Amount, int UserId)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Amount = Amount;
        this.UserId = UserId;
    }
    }
    
}