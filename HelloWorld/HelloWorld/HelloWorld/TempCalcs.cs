using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TempCalcs
    {
        public static void PrintAndConvertTemp()
        {

            Console.Write("Zadejte teplotu ve st. F: ");
            double fahr = double.Parse(Console.ReadLine());
            double cels = PrevodTeploty(fahr);

            Console.WriteLine($"Teplota ve stupních C: {cels}");
        }

        static double PrevodTeploty(double f)
        {
            return Math.Round((f - 32) * (5d / 9d), 2);
        }
    }
}
