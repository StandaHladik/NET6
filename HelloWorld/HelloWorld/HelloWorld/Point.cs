using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Point
    {

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        public uint X { get; set; }
        public uint Y { get; set; }

        public override string ToString()
        {
            return "Souřadnice X: " + X + " Souřadnice Y: " + Y;
        }

        public static Point GetDefaultPoint()
        {
            return new Point(100, 100);
        }

        public uint Obsah()
        {
            return (this.X * this.Y);
        }

    }
}
