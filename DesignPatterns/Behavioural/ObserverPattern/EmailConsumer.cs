﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ObserverPattern
{
    public class EmailConsumer : IBitCoinConsumer
    {
        public void consume(double amount)
        {
            Console.WriteLine("Sent email");
        }
    }
}
