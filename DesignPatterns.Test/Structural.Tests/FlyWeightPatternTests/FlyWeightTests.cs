using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Structural.FlyWeightPattern;

namespace DesignPatterns.Test.Structural.Tests.FlyWeightPatternTests
{
    public class FlyWeightTests
    {
        [Fact]
        public void testFlyWeight()
        {
            Bullet nineMMBullet = new Bullet(2, 2, "sdf", BullerType.NineMM);
            Bullet sevenMMBullet = new Bullet(2, 2, "sdf", BullerType.SevenMM);

            BulletRegistry registry = BulletRegistry.getInstance();
            registry.register(nineMMBullet);
            registry.register(sevenMMBullet);

            FlyingBullet bullet1 = new FlyingBullet(1, 1, 1, 1, registry.getBullet(BullerType.NineMM));
            FlyingBullet bullet2 = new FlyingBullet(1, 1, 1, 1, registry.getBullet(BullerType.SevenMM));
        }
    }
}
