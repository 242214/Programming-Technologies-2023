using Data.API;

namespace Service.Implementation
{
    internal class State : IState
    {
        public State(int Id, int ProductId, int Amount, bool isAvailable)
        {
           this.Id=Id;
           this.ProductId=ProductId;
           this.Amount=Amount;
           this.isAvailable=isAvailable;
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
    }
}