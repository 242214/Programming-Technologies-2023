using Data.API;
using Data;

namespace Service.Implementation
{
    internal class Order : IOrder
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