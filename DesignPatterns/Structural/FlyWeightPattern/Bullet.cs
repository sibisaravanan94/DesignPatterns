using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeightPattern
{
    // Step 1 -> Create Intrinsic class
    public class Bullet
    {
        public double Radius { get; set; }
        public BullerType type { get; set; }
        public double weight { get; set; }
        public string image { get; set; }

        public Bullet(double radius, double weight, string image, BullerType type)
        {
            this.Radius = radius;
            this.type = type;
            this.weight = weight;
            this.image = image;
        }
    }
}
