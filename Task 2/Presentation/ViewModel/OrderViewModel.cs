using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Presentation.Model.API;
using System.Windows.Input;

namespace Presentation.ViewModel
{
     public partial class OrderViewModel : ObservableObject
    {
        private IOrderModel _order;

        public OrderViewModel(IOrderModel order)
        {
            _order = order;
        }

        public int Id
        {
            get { return _order.Id; }
            set
            {
                _order.Id = value;
                OnPropertyChanged();
            }
        }
        public int ProductId { 
            get => _order.ProductId;
            set
            {
                _order.ProductId = value;
                OnPropertyChanged();
            } }
        public int Buy { 
            get => _order.Buy;
            set
            {
                _order. Buy = value;
                OnPropertyChanged();
            } }
        public int Sell
        {
            get => _order.Sell;
            set
            {
                _order.Sell = value;
                OnPropertyChanged();
            }
        }
        public int UserId { 
            get => _order.UserId;
            set
            {
                _order.UserId = value;
                OnPropertyChanged();
            } }
        private ICommand _addOrderCommand;
        public ICommand AddOrderCommand => _addOrderCommand ??= new AsyncRelayCommand(AddOrder);

        private ICommand _deleteOrderCommand;
        public ICommand DeleteOrderCommand => _deleteOrderCommand ??= new AsyncRelayCommand(DeleteOrder);

        private async Task AddOrder()
        {
            await _order.AddAsync();
        }

        private async Task DeleteOrder()
        {
            await _order.DeleteAsync();
        }
       

    }
}
