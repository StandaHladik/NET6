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

            int a = 20;
            int b = 30;

            // Prohození

            Console.WriteLine($"a: {a}, b: {b}");

            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a: {a}, b: {b}");

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

    }
}
