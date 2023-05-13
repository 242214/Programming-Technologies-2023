using Data.API;

namespace Service.Implementation
{
    internal class State : IState
    {
        //private readonly IProduct product;

        public State(int Id, int ProductId, uint Amount, bool isAvailable)
        {
           this.Id=Id;
           this.ProductId=ProductId;
           this.Amount=Amount;
           this.isAvailable=isAvailable;
        }

        //public string ProductId => product.Id;
        public int Id { get; set; }
        public int ProductId { get; set; }
        public uint Amount { get; set; }
        public bool isAvailable { get; set; }
    }
}
