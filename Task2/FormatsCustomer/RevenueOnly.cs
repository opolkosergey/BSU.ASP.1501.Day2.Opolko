using System.Globalization;

namespace Task2.FormatsCustomer
{
    public class RevenueOnly : IFormatCustomer
    {
        private Customer _customer;

        public RevenueOnly(Customer customer)
        {
            _customer = customer;
        }

        public string GetFormatConsumer()
        {
            return _customer.Revenue.ToString(CultureInfo.CurrentCulture);
        }
    }
}
