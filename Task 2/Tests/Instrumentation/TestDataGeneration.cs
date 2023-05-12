using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Tests.Instrumentation
{
    internal class TestDataGeneration
    {
        internal static IEnumerable<ICustomer> PrepareData()
        {
            return new List<Customer>()
        {
          new Customer(1, "First", "Customer"),
          new Customer(2, "Second", "Customer"),
          new Customer(3, "Mister", "Clever")
        };
        }

        private class Customer : ICustomer
        {
            public Customer(int Id, string firstName, string lastName)
            {
                this.Id = Id;
                FirstName = firstName;
                LastName = lastName;
                // for (int i = 0; i < 5; i++)
                // {
                //   _assignedCDs.Add(new CDCatalog()
                //   {
                //     Country = $"Country{i}",
                //     Person = this,
                //     Price = 0,
                //     Title = $"Title{i}",
                //     Year = (ushort)(2000 + i)
                //   });
                // }
            }

            #region ICustomer

            public int Id { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            //public IEnumerable<ICDCatalog> CDs => _assignedCDs;

            #endregion ICustomer
            //private List<ICDCatalog> _assignedCDs = new List<ICDCatalog>();
        }

        private class Product : IProduct
        {
            #region IProduct

            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }


            #endregion IProduct
        }




        private class State : IState
        {
            public State(int Id, int ProductId, uint Amount, bool isAvailable)
            {
                this.Id = Id;
                this.ProductId = ProductId;
                this.Amount = Amount;
                this.isAvailable = isAvailable;
            }

            #region IState

            public int Id { get; private set; }
            public int ProductId { get; private set; }
            public uint Amount { get; private set; }
            public bool isAvailable { get; private set; }

            #endregion IState
        }

        private class Order : IOrder
        {
            public Order(int Id, int ProductId, uint Amount, bool isAvailable)
            {
                this.Id = Id;
                this.ProductId = ProductId;
                this.Amount = Amount;
                this.isAvailable = isAvailable;
            }

            #region IOrder

            public int Id { get; private set; }
            public int ProductId { get; private set; }
            public uint Amount { get; private set; }
            public int UserId { get; private set; }

            #endregion IOrder
        }
    }
}