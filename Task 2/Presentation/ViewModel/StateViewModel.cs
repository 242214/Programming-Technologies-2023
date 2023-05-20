using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class StateViewModel : ObservableObject
    {
        private IState _state;

        public StateViewModel(IState state)
        {
            _state = state;
        }

        public int Id
        {
            get { return _state.Id; }
            set
            {
                _state.Id = value;
                OnPropertyChanged();
            }
        }
        public int ProductId
        {
            get { return _state.ProductId; }
            set
            {
                _state.ProductId = value;
                OnPropertyChanged();
            }
        }
        public int Amount { 
            get => _state.Amount;
            set
            {
                _state.Amount = value;
                OnPropertyChanged();
            } }
        public bool isAvailable { 
            get => _state.isAvailable;
            set
            {
                _state.isAvailable = value;
                OnPropertyChanged();
            } }
        // [ICommand]
        // private async Task AddState()
        // {
        //     await _product.AddAsync();
        // }
        // [ICommand]
        // private async Task DeleteState()
        // {
        //     await _product.DeleteAsync();
        // }

    }
}
