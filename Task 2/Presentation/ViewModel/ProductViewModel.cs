
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class ProductViewModel : ObservableObject
    {
        private IProduct _product;

        public ProductViewModel(IProduct product)
        {
            _product = product;
        }

        public int Id
        {
            get { return _product.Id; }
            set
            {
                _product.Id = value;
                OnPropertyChanged();
            }
        }
        public string Name { 
            get => _product.Name;
            set
            {
                _product.Name = value;
                OnPropertyChanged();
            } }
        public double Price { 
            get => _product.Price;
            set
            {
                _product.Price = value;
                OnPropertyChanged();
            } }
        // [ICommand]
        // private async Task AddProduct()
        // {
        //     await _product.AddAsync();
        // }
        // [ICommand]
        // private async Task DeleteProduct()
        // {
        //     await _product.DeleteAsync();
        // }

    }
}
