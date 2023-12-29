using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioural.ObserverPattern;
using Xunit;

namespace DesignPatterns.Test.Behavioural.Tests.ObserverPatternTests
{
    public class ObserverTests
    {
        [Fact]
        public void testOberver()
        {
            BitCoinManager manager = new BitCoinManager();
            manager.addConsumer(new EmailConsumer());
            manager.addConsumer(new SMSConsumer());

            manager.updateBitCoin(90);
        }
        
    }
}
