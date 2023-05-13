using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation.DB
{
    internal class ORDER : IOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public uint Amount { get; set; }
        public int UserId { get; set; }
    }
}