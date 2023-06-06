using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model.API
{
    public interface IOrderModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
        public int UserId { get; set; }
        public IServiceModel Servicee { get; }
        
        public Task AddAsync();
        public Task DeleteAsync();
    }
}