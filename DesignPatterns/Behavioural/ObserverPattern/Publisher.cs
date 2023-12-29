using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ObserverPattern
{
    public abstract class Publisher
    {
        private List<IBitCoinConsumer> consumers { get; set; } = new List<IBitCoinConsumer>();
        protected void publish(double amount)
        {
            foreach(IBitCoinConsumer consumer in consumers)
            {
                consumer.consume(amount);
            }
        }

        public void addConsumer(IBitCoinConsumer consumer)
        {
            consumers.Add(consumer);
        }

        public void removeConsumer(IBitCoinConsumer consumer)
        {
            consumers.Remove(consumer);
        }
    }
}
