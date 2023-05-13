using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Service.API;
using Data.API;
using Data;

namespace Service.Implementation
{
    internal class Customer : ICustomer
    {
        public Customer(int Id, string FirstName, string LastName)
        {
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
