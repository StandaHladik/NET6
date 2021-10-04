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

            int a = 20;
            int b = 30;

            Console.WriteLine($"Porovnání čísel {a} a {b}:");

            int vetsiCislo = VetsiCislo(a, b);

            Console.WriteLine($"Větší číslo je: {vetsiCislo}");

        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name} !");
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
            int vetsiCislo;

            if(a > b)
            {
                vetsiCislo = a;
            }
            else
            {
                vetsiCislo = b;
            }

            return vetsiCislo;
        }

    }
}
