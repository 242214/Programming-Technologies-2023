using Data.API;

namespace Data.Implementation
{
    internal class State : IState
    {
        private readonly IProduct product;
        public int Id { get; set; }
        public int ProductId => product.Id;
        public uint Amount { get; set; }
        public bool isAvailable { get; set; }
        public State(int Id, uint Amount, bool isAvailable, IProduct product)
        {
            this.Id=Id;
            this.product=product;
            this.Amount=Amount;
            this.isAvailable=isAvailable;
        }
    }
}
