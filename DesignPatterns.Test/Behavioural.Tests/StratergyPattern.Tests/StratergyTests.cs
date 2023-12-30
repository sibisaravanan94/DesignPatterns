using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioural.StratergyPattern;
using Xunit;

namespace DesignPatterns.Test.Behavioural.Tests.StratergyPattern.Tests
{
    public class StratergyTests
    {
        [Fact]
        public void testStratergy()
        {
            Navigator car = new Navigator(new FourWheelerStratergy());
            double time = car.navigate("Namakkal", "Salem");
            Assert.Equal(time,(Double)(4.0));

            Navigator bike = new Navigator(new TwoWheelerStratergy());
            double bikeTime = bike.navigate("Namakkal", "Salem");
            Assert.Equal(bikeTime, 2.0);
        }
    }
}
