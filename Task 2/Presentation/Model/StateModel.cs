using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model
{
    public class StateModel : IState
    {
        public StateModel(int Id, int productId, int amount, IService service)
        {
            this.Id=Id;
            ProductId = productId;
            Amount = amount;
            isAvailable = true;
            Servicee = service;
        }
 
        public int Id { get; set; }
        public int ProductId { get; set;  }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
        public IService Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddState(this);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteState(this.Id);
        }
    }
}
