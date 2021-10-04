using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Hello("Stando");
            //int sum = Add(5, 3);
            //Console.WriteLine(sum);
            //AddAndPrint(95, 55);
        }

        static void Hello(string jmeno)
        {
            Console.WriteLine($"Hello {jmeno} !");
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
