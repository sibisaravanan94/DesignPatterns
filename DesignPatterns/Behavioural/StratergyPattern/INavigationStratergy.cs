using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.StratergyPattern
{
    public interface INavigationStratergy
    {
        double navigate(string from, string to);
    }
}
