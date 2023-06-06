using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model.API;

namespace Presentation.ViewModel
{
    public partial class StateViewModel : ObservableObject
    {
        private IStateModel _state;

        public StateViewModel(IStateModel state)
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
        private ICommand _addStateCommand;
        public ICommand AddStatetCommand => _addStateCommand ??= new AsyncRelayCommand(AddState);

        private ICommand _deleteStateCommand;
        public ICommand DeleteStateCommand => _deleteStateCommand ??= new AsyncRelayCommand(DeleteState);

        private async Task AddState()
        {
            await _state.AddAsync();
        }

        private async Task DeleteState()
        {
            await _state.DeleteAsync();
        }

    }
}
