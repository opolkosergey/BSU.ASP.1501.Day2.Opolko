using System;
using System.Text;

namespace Task2
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public Customer()
        {
            Name = "Jeffrey Richter";
            ContactPhone = "+1(425)555-0100";
            Revenue = 1000000;
        }

        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }

        public string ToString(params IFormatCustomer[] formatsCustomers)
        {
            var s = new StringBuilder();

            foreach (IFormatCustomer format in formatsCustomers)
            {
                s.Append(format.GetFormatConsumer());
                s.Append(' ');
            }
                
            return s.ToString();
        }
    }
}
