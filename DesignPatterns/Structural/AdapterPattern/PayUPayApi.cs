using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.AdapterPattern
{
    internal class PayUPayApi
    {
        public void createPayment(int id, double amount)
        {
            Console.Write("PayU payment");
        }

        public PayUStatus CheckStatus(int id)
        {
            return PayUStatus.ok;
        }
    }
}
