using Data.API;
using Data.Implementation;

namespace Logic.API
{
    public abstract class IBusinessLogic
    {
        public abstract void BuyProduct(int Id, uint Amount);
        public abstract void SellProduct(int Id, int ProductId, uint OrderAmount);
    }
}