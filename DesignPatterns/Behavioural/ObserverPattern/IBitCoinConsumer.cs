using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ObserverPattern
{
    public interface IBitCoinConsumer
    {
        void consume(double amount);
    }
}
