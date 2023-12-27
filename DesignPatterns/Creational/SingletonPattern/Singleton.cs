using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SingletonPattern
{
    // Make it sealed to prevent inner class to inherite singleton class
    public sealed class Singleton
    {
        // Step 3 - Create privae static obj
        private static Singleton _instance = null;

        // Eager initialization, creates obj at class load time
        // private static Singleton _instance = new Singleton();
        private static readonly object obj = new object();
        // Step 1 - Make constructor private
        private Singleton()
        {

        }
        // Step 2 - Create static initializer method
        public static Singleton getSingleton()
        {
            // Step 4 - simple logic to return object
            // Double check locking
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
