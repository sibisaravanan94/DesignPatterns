﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioural.ObserverPattern;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitCoinManager manager = new BitCoinManager();
            manager.addConsumer(new EmailConsumer());
            manager.addConsumer(new SMSConsumer());

            manager.updateBitCoin(90);
            string x = Console.ReadLine();
            manager.updateBitCoin(91);
            x = Console.ReadLine();
            manager.updateBitCoin(80);
            x = Console.ReadLine();
        }
    }
}
