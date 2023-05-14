using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
namespace Data.Implementation
{
    internal class State : IState
    {
        public State(int id, int productId, int amount, bool isAvailable)
        {
            Id = id;
            ProductId = productId;
            Amount = amount;
            this.isAvailable = isAvailable;
        }

        public int Id { get; set; }
        public int ProductId { get; set;  }
        public int Amount { get; set; }
        public bool isAvailable { get; set; }
    }
}
