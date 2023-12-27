using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.AdapterPattern
{
    public class RazorPayApi
    {
        public void makePayment(int id, string name, string email, double amount)
        {
            Console.WriteLine("RazorPay payment");
        }

        public RazorPayStatus GetStatus(int id)
        {
            return RazorPayStatus.success;
        }
    }
}
