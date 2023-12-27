using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypePattern
{
    public class BackgroundObject : IGraphicalObject
    {
        public int x { get; set; }
        public int y { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public BackgroundObjectType type { get; set; }
        public List<int> pixel { get; set; } = new List<int>();
        public BackgroundObject(int x, int y, int height, int width, BackgroundObjectType type)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.type = type;
            this.pixel = generatePixel(height, width);
        }

        private BackgroundObject(BackgroundObject reference)
        {
            this.x = reference.x;
            this.y = reference.y;
            this.height = reference.height;
            this.width = reference.width;
            this.type = reference.type;
            this.pixel = reference.pixel;
        }
        // Step 2 -> implement clone method with shallow copy constructor
        public IGraphicalObject Clone()
        {
            return new BackgroundObject(this);
        }

        // Time consu,ing expensive operation
        private List<int> generatePixel(int height, int width)
        {
            Thread.Sleep(3000);
            return new List<int>();
        }
    }
}
