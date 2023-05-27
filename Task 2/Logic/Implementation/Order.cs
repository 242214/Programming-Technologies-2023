using Data.API;
using Data;

namespace Service.Implementation
{
    internal class Order : IOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
        public int UserId { get; set; }
        public Order(int Id, int ProductId, int Buy, int Sell, int UserId)
        {
            this.Id = Id;
            this.ProductId = ProductId;
            this.Buy = Buy;
            this.Sell = Sell;
            this.UserId = UserId;
        }
    }
}