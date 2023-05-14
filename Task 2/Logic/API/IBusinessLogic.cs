using Data.API;
using Data.Implementation;
using Logic.Implementation;

namespace Logic.API
{
    public abstract class IBusinessLogic
    {
        public abstract void BuyProduct(int Id, int ProductId, int Amount);
        public abstract void SellProduct(int Id, int ProductId, int OrderAmount, int UserId);
        public static IBusinessLogic CreateBusinessLogic()
        {
            return new BusinessLogic();
        }
    }
}