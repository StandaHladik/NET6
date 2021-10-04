using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hello();
            //int sum = Add(5, 3);
            //Console.Write(sum);
            AddAndPrint(95, 55);
        }

        static void Hello()
        {
            Console.WriteLine("Hello!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddAndPrint(int a, int b)
        {
            int sum;

            sum = a + b;

            Console.WriteLine(sum);

        }
    }
}
