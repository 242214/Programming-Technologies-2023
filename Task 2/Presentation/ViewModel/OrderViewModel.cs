using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Service.API;

namespace Presentation.ViewModel
{
     public partial class OrderViewModel : ObservableObject
    {
        private IOrder _order;

        public OrderViewModel(IOrder order)
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
        public int Amount { 
            get => _order.Amount;
            set
            {
                _order.Amount = value;
                OnPropertyChanged();
            } }
        public int UserId { 
            get => _order.UserId;
            set
            {
                _order.UserId = value;
                OnPropertyChanged();
            } }
        // [ICommand]
        // private async Task AddOrder()
        // {
        //     await _product.AddAsync();
        // }
        // [ICommand]
        // private async Task DeleteOrder()
        // {
        //     await _product.DeleteAsync();
        // }

    }
}
