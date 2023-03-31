using Data.API;
using Logic.API;
namespace Logic.Implementation;

public class Class1
{
	public void BuyProduct(int Id, uint Amount)
	{
		if (Product.Amount.get() < Amount) throw new Exeption("Not enough product");
		if (Amount == 0) throw new Exception("Product Amount cannot be equal or lesser than 0");
		//if() invalid id check
		IOrder buy = new IOrder();
	}
	public void SellProduct(int Id, int OrderAmount){
		
		
	}
}
