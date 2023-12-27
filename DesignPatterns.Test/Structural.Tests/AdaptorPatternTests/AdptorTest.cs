using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.AdapterPattern;
using Xunit;

namespace DesignPatterns.Test.Structural.Tests.AdaptorPatternTests
{
    public class AdptorTest
    {
        [Fact]
        public void testAdaptor()
        {
            // Arrange
            IPaymentProvider adaptor1 = new RazorPayAdaptor();
            IPaymentProvider adaptor2 = new RazorPayAdaptor();
            // Act
            adaptor1.makePayment(1, "sibi", "async@ad.com", 1000);
            var status1 = adaptor1.verifyStatus(1);

            adaptor2.makePayment(1, "sibi", "async@ad.com", 1000);
            var status2 = adaptor2.verifyStatus(1);
            // Assert
            Assert.IsType(typeof(PaymentStatus), status1);
            Assert.IsType(typeof(PaymentStatus), status2);
        }
    }
}
