using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.AdapterPattern
{
    public class RazorPayAdaptor : IPaymentProvider
    {
        private RazorPayApi api = new RazorPayApi();
        public void makePayment(int id, string name, string email, double amount)
        {
            api.makePayment(id, name, email, amount);
        }

        public PaymentStatus verifyStatus(int id)
        {
            RazorPayStatus status = api.GetStatus(id);
            return to(status);
        }

        private PaymentStatus to(RazorPayStatus status)
        {
            if (status == RazorPayStatus.success)
            {
                return PaymentStatus.success;
            }
            else
            {
                return PaymentStatus.fail;
            }
        }
    }
}
