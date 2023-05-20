using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel 
{
    public partial class CustomerViewModel: ObservableObject
    {
        private ICustomer _customer;
        public CustomerViewModel(ICustomer customer)
        {
            _customer = customer;
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
        // //[ICommand]
        // private async Task AddCustomer()
        // {
        //     await _customer.AddAsync();
        // }
        // //[ICommand]
        // private async Task DeleteCustomer()
        // {
        //     await _customer.DeleteAsync();
        // }

    }
}
