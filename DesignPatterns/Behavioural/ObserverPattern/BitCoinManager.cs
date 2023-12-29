using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ObserverPattern
{
    public class BitCoinManager : Publisher
    {
        BitCoin bitCoin = new BitCoin(99);
        public void updateBitCoin(double amount)
        {
            double oldAmount = bitCoin.Amount;
            bitCoin.Amount = amount;

            if(bitCoin.Amount < oldAmount - 5)
            {
                publish(bitCoin.Amount);
            }
        }
    }
}
