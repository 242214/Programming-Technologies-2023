using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation.DB
{
    internal class PRODUCT : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}