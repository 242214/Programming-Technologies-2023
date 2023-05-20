using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model.API
{
    public class StateModel : Service.API.IState
    {
        public int Id { get; set; }
        public int ProductId { get; set;  }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
        public IService Servicee { get; }

        public async Task AddAsync();
        public async Task DeleteAsync();
    }
}
