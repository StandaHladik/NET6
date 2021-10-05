using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Úterý
            //Console.Write("Zadejte rok narození: ");
            //int vek = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Vaše generace je: {Generace(vek)}");

            Console.Write("Zadejte číslo dne: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Název dne v týdnu je: {GetDayName(number)}");

        }

        static string GetDayName(int number)
        {

            switch (number)
            {
                case 1:
                    return "Pondělí";
                case 2:
                    return "Úterý";
                case 3:
                    return "Středa";
                case 4:
                    return "Čtvrtek";
                case 5:
                    return "Pátek";
                case 6:
                    return "Sobota";
                case 7:
                    return "Neděle";
                default:
                    return "";
            }

        }

        // Úterý
        static string Generace(int year)
        {
            string generace = "Boomers";

            if (year > 1946 && year <= 1964)
            {
                generace = "Baby Boomers";
            }
            else if (year >= 1965 && year <= 1980)
            {
                generace = "X";
            }
            else if (year >= 1981 && year <= 1996)
            {
                generace = "Millenial";
            }
            else if (year >= 1997 && year <= 2012)
            {
                generace = "Z";
            }
            else if (year >= 1946 && year <= 1964)
            {
                generace = "Aplha";
            }

            return generace;
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
