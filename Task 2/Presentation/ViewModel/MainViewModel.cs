using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Data.API;

namespace Presentation.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() 
        {
            //Data = IDataRepository.CreateDatabase();
            CustomerViewModel = new CustomerViewModel(new CustomerModel());
        }
    }
}
