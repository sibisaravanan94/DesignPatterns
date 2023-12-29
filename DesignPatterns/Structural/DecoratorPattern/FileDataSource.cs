using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class FileDataSource : IDataSource
    {
        public string read()
        {
            string data = "Base";
            return data;
        }

        public void write(string data)
        {
            Console.WriteLine(" - Base write ");
        }
    }
}
