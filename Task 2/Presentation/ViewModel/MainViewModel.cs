using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Model.API;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IServiceModel service;
            public CustomerViewModel CustomerVM { get; }
            public OrderViewModel OrderVM { get; }
            public ProductViewModel ProductVM { get; }
            public StateViewModel StateVM { get; }

            public MainViewModel(ICustomerModel customer, IOrderModel order, IProductModel product, IStateModel state)
            {
            service = IServiceModel.Create();
                CustomerVM = new CustomerViewModel(customer);
                OrderVM = new OrderViewModel(order);
                ProductVM = new ProductViewModel(product);
                StateVM = new StateViewModel(state);
            }

        public MainViewModel()
        {
        }

        [ObservableProperty]
            private MainViewModel _activeProduct;
            private int _selectedProduct;

            public int SelectedProduct
            {
                get => _selectedProduct;
                set
                {
                    _selectedProduct = value;
                    OnPropertyChanged();
                    try
                    {
                        _activeProduct = new MainViewModel();
                        OnPropertyChanged(nameof(ActiveProduct));
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }

        [ObservableProperty]
        private MainViewModel _activeCustomer;
        private int _selectedCustomer;

        public int SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
                try
                {
                    _activeCustomer = new MainViewModel();
                    OnPropertyChanged(nameof(ActiveCustomer));
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
    }
}
