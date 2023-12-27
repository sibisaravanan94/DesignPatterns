using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.AdapterPattern
{
    public interface IPaymentProvider
    {
        void makePayment(int id, string name, string email, double amount);
        PaymentStatus verifyStatus(int id);
    }
}
