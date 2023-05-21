using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model.API
{
    public interface IOrderModel : Service.API.IOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
        public IService Servicee { get; }
        
        public Task AddAsync();
        public Task DeleteAsync();
    }
}