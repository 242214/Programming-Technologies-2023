using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model.API;

namespace Presentation.ViewModel 
{
    public partial class CustomerViewModel: ObservableObject
    {
        private ICustomerModel _customer;
        public CustomerViewModel(ICustomerModel customer)
        {
            _customer = customer;
        }
        public CustomerViewModel()
        {
        }
        public int CustomerId {
            get =>  _customer.Id;
            set
            {
                _customer.Id = value;
                OnPropertyChanged();
            } }
        public string Name { 
            get => _customer.FirstName;
            set
            {
                _customer.FirstName = value;
                OnPropertyChanged();
            } }
        public string Surname { 
            get => _customer.LastName;
            set
            {
                _customer.LastName = value;
                OnPropertyChanged();
            } }
        private ICommand _addCustomerCommand;
        public ICommand AddCustomerCommand => _addCustomerCommand ??= new AsyncRelayCommand(AddCustomer);

        private ICommand _deleteCustomerCommand;
        public ICommand DeleteCustomerCommand => _deleteCustomerCommand ??= new AsyncRelayCommand(DeleteCustomer);

        private async Task AddCustomer()
        {
            await _customer.AddAsync();
        }

        private async Task DeleteCustomer()
        {
            await _customer.DeleteAsync();
        }

    }
}
