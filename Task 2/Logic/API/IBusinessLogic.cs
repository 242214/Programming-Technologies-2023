using Data.API;
using Data.Implementation;
using Service.Implementation;

namespace Service.API
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