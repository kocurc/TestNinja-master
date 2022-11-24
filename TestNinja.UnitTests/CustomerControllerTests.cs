using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        // TODO Testing return type
        [Test]
        public void GetCustomer_IdIs0_ReturnsNotFoundObject()
        {
            var customerController = new CustomerController();

            var result = customerController.GetCustomer(0);

            Assert.IsInstanceOf<NotFound>(result);
        }

        [Test]
        public void GetCustomer_IdIs5_ReturnsOkObject()
        {
            var customerController = new CustomerController();

            var result = customerController.GetCustomer(5);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
