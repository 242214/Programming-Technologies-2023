//using Data.API;
//using Data;
using Service.API;
namespace Service.Implementation
{
    internal class Sell : ISell
    {
        //public int Id { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public uint Amount { get; set; }
        public int UserId { get; set; }

        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}