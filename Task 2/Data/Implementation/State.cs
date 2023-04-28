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
        public int Id { get; set; }
        public int ProductId { get; set;  }
        public uint Amount { get; set; }
        public bool isAvailable { get; set; }
        //public State(int Id, int ProductId, uint Amount, bool isAvailable)
        //{
        //    this.Id=Id;
        //    this.ProductId=ProductId;
        //    this.Amount=Amount;
        //    this.isAvailable=isAvailable;
        //}
    }
}
