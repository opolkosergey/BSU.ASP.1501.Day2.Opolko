using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.FormatsCustomer;

namespace Task2.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void ToString_Test()
        {
            Customer customer = new Customer();
            IFormatCustomer nameOnly = new NameOnly(customer);
            IFormatCustomer contactPhoneOnly = new ContactPhoneOnly(customer);
            IFormatCustomer revenueOnly = new RevenueOnly(customer);
            IFormatCustomer reverseName = new ReverseDataCustomer(customer);

            string s1 = "Jeffrey Richter ";
            string s2 = "Jeffrey Richter +1(425)555-0100 1000000 ";
            string s3 = "+1(425)555-0100 ";
            string s4 = "rethciR yerffeJ ";

            string r1 = customer.ToString(nameOnly);
            string r2 = customer.ToString(nameOnly, contactPhoneOnly, revenueOnly);
            string r3 = customer.ToString(contactPhoneOnly);
            string r4 = customer.ToString(reverseName);

            Assert.AreEqual(s1,r1);
            Assert.AreEqual(s2,r2);
            Assert.AreEqual(s3,r3);
            Assert.AreEqual(s4,r4);
        }
    }
}
