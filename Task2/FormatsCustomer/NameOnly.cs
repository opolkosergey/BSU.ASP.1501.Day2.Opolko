namespace Task2.FormatsCustomer
{
    public class NameOnly : IFormatCustomer
    {
        private Customer _customer;
        public NameOnly(Customer customer)
        {
            _customer = customer;
        }
        public string GetFormatConsumer()
        {
            return _customer.Name;
        }
    }
}
