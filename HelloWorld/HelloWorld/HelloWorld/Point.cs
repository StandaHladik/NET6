using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Point
    {
        // Často se pojemnovává s podtržítkem pro použití uvnitř třídy
        private uint _x = 0;


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

        public uint X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                {
                    _x = (uint)(value * (-1));
                }
                else
                {
                    _x = (uint)value;
                }
            }
        }

        public uint GetX()
        {
            return _x;
        }
        public void SetX(int val)
        {
            if(val < 0)
            {
                _x = (uint)(val * (-1));
            }
            else
            {
                _x = (uint)val;
            }
        }

        //public uint X { get; set; } = 0;
        public uint Y { get; set; } = 0;

        public string Color { get; set; }

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
