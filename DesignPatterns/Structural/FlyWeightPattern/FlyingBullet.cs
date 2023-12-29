using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeightPattern
{
    // Step 2 -> Create Extrinsic class
    public class FlyingBullet
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double direction { get; set; }
        // Step 3 -> add reference
        public Bullet bullet { get; set; }

        public FlyingBullet(double x, double y, double z, double direction, Bullet bullet)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.direction = direction;
            this.bullet = bullet;
        }
    }
}
