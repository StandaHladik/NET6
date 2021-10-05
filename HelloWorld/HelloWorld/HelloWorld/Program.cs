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
                    //return "Sobota";
                case 7:
                    //return "Neděle";
                    return "Víkend";
                default:
                    return "";
            }

        }

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
    }
}
