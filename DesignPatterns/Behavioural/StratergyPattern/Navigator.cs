using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.StratergyPattern
{
    public class Navigator
    {
        public INavigationStratergy NavigationStratergy { get; set; }
        public Navigator(INavigationStratergy navigationStratergy)
        {
            this.NavigationStratergy = navigationStratergy;
        }

        public double navigate(string from, string to)
        {
            return NavigationStratergy.navigate(from, to);
        }
    }
}
