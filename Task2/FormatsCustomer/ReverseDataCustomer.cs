using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.FormatsCustomer
{
    public class ReverseDataCustomer : IFormatCustomer
    {
        private Customer _customer;
        public ReverseDataCustomer(Customer customer)
        {
            _customer = customer;
        }

        public string GetFormatConsumer()
        {
            return new string(_customer.Name.Reverse().ToArray());
        }
    }
}
