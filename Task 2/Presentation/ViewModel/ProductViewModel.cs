
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class ProductViewModel : ObservableObject
    {
        //int Id;
        //string Name;
        //double Price;
        private IProduct _product;

        public ProductViewModel(IProduct product)
        {
            _product = product;
        }
        public ProductViewModel(int Id, string Name, double Price) 
        {
            _product.Id = Id;
            _product.Name = Name;
            _product.Price = Price;
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
        private ICommand _addProductCommand;
        public ICommand AddProductCommand => _addProductCommand ??= new AsyncRelayCommand(AddProduct);

        private ICommand _deleteProductCommand;
        public ICommand DeleteProductCommand => _deleteProductCommand ??= new AsyncRelayCommand(DeleteProduct);

        private async Task AddProduct()
        {
            await _product.AddAsync();
        }

        private async Task DeleteProduct()
        {
            await _product.DeleteAsync();
        }

    }
}
