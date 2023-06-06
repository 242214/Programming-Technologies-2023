using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
using Presentation.Model.API;

namespace Presentation.Model
{
    public class StateModel : IStateModel
    {
        public StateModel(int Id, int productId, int amount, IServiceModel service)
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
        public IServiceModel Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddStateAsync(Id, ProductId, Amount, isAvailable);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteStateAsync(this.Id);
        }
    }
}
