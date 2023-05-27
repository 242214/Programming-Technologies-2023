using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
using Presentation.Model.API;

namespace Presentation.Model
{
    public class OrderModel : IOrderModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
        public int UserId { get; set; }
        public IService Servicee { get; }
        
        public OrderModel(int Id, int ProductId, int Buy, int Sell, int UserId, IService service)
        {
            this.Id = Id;
            this.ProductId = ProductId;
            this.Buy = Buy;
            this.Sell = Sell;
            this.UserId = UserId;
            Servicee = service;
        }

        public async Task AddAsync()
        {
            await Servicee.AddOrderAsync(Id, ProductId, Buy, Sell, UserId);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteOrderAsync(this.Id);
        }
    }
}