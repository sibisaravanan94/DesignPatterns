using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.AdapterPattern
{
    public class PayUAdaptor : IPaymentProvider
    {
        private PayUPayApi api = new PayUPayApi();
        public void makePayment(int id, string name, string email, double amount)
        {
            api.createPayment(id, amount);
        }

        public PaymentStatus verifyStatus(int id)
        {
            PayUStatus status = api.CheckStatus(id);
            return to(status);
        }

        private PaymentStatus to(PayUStatus status)
        {
            if (status == PayUStatus.ok)
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
