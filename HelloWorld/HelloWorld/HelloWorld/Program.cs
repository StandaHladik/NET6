using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Hello("Standa");
            //int sum = Add(5, 3);
            //Console.WriteLine(sum);
            //AddAndPrint(95, 55);

            //int a = 20;
            //int b = 30;

            // Prohození

            //Console.WriteLine($"Původní hodnoty");
            //Console.WriteLine($"a: {a}, b: {b}");

            //int c = 0;

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine($"Nové hodnoty");
            //Console.WriteLine($"a: {a}, b: {b}");

            //string str = "jmeno";
            //char chr = 'a';

            //DateTime date = new DateTime(1999, 12, 31);

            //if (a == 20)
            //{
            //    Console.WriteLine("Jsem v podmínce");
            //}
            //else
            //{
            //    Console.Write("Jsem v else");
            //}

            //Console.WriteLine("Jsem za ifem");

            //const int c_a = 155;
            //const int c_b = 255;

            //int a = 255;
            //int b = 30;

            //Console.WriteLine($"Porovnání čísel {a} a {b}:");

            //int vetsiCislo = VetsiCislo(a, b);

            //Console.WriteLine($"Větší číslo je: {vetsiCislo}");

            //if ((a == c_a) || (a == c_b))
            //{
            //    Console.WriteLine($"False");
            //}
            //else
            //{
            //    if(a > b)
            //    {
            //        Console.WriteLine($"True");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"False");
            //    }
            //}

            //Console.Write("Napište Vaše jméno: ");
            //var input = Console.ReadLine();
            //Hello(input);

            //int a = 23;
            //double d = 444.6698;
            //a = (int)Math.Round(d, 0);
            //Console.WriteLine(a);

            //string input = Console.ReadLine();
            //int num = int.Parse(input);
            //var d = double.Parse(input);

            //num.ToString();

            //Console.WriteLine($"vstup + 10: {d + 10}");

            Console.WriteLine("Zadejte teplotu ve st. F: ");
            Console.WriteLine($"Teplota ve stupních C: {PrevodTeploty(double.Parse(Console.ReadLine()))}");

        }

        static double PrevodTeploty(double f)
        {
            double c;

            c = (f - 32) * (5d / 9d);

            return c;

        }


        static bool IsGreater(int a, int b)
        {
            var x = (a > b) ? a : b;

            return (a > b);          
        }

        static void Hello(string name)
        {
            string pozdrav = "";
            string nameUpper = name.ToUpper();

            if((nameUpper == "Bob".ToUpper()) || (nameUpper == "Alice".ToUpper()))
            {
                pozdrav = "Vítej zpět";
            }
            else
            {
                pozdrav = "Vítej";
            }

            Console.WriteLine($"{pozdrav} {name} !");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int AddAndPrint(int a, int b)
        {
            int sum;

            sum = a + b;

            Console.WriteLine($"Součet a + b: {a} + {b} = {sum}");

            return sum;
        }

        static int VetsiCislo(int a, int b)
        {
            int vetsiCislo = 0;

            if (a > b)
            {
                vetsiCislo = a;
            }
            else if (b > a)
            {
                vetsiCislo = b;
            }
            else
            {
                vetsiCislo = a;
            }

            return vetsiCislo;
        }

    }
}
