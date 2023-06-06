using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.API
{
    public interface IStateModel
    {
        public int Id { get; set; }
        public int ProductId { get; set;  }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
        public IServiceModel Servicee { get; }

        public Task AddAsync();
        public Task DeleteAsync();
    }
}
