using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.StratergyPattern
{
    public class FourWheelerStratergy : INavigationStratergy
    {
        public double navigate(string from, string to)
        {
            return 4.0;
        }
    }
}
