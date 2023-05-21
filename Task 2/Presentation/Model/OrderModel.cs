using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Service.API;
using Presentation.Model.API;

namespace Presentation.Model
{
    public class OrderModel : IOrderModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
        public IService Servicee { get; }
        
        public OrderModel(int Id, int ProductId, int Amount, int UserId, IService service)
        {
            this.Id = Id;
            this.ProductId = ProductId;
            this.Amount = Amount;
            this.UserId = UserId;
            Servicee = service;
        }

        public async Task AddAsync()
        {
            await Servicee.AddOrderAsync(Id, ProductId, Amount, UserId);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteOrderAsync(this.Id);
        }
    }
}