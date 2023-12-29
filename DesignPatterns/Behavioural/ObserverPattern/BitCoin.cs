using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ObserverPattern
{
    public class BitCoin
    {
        public double Amount { get; set; }
        public BitCoin(double amount)
        {
            this.Amount = amount;
        }
    }
}
