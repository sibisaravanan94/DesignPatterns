using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.StratergyPattern
{
    public class TwoWheelerStratergy : INavigationStratergy
    {
        public double navigate(string from, string to)
        {
            return 2.0;
        }
    }
}
