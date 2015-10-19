using System;

namespace Task2.FormatsCustomer
{
    public class ContactPhoneOnly : IFormatCustomer
    {
        private Customer _customer;
        public ContactPhoneOnly(Customer customer)
        {
            _customer = customer;
        }

        public string GetFormatConsumer()
        {
            return _customer.ContactPhone;
        }
    }
}
