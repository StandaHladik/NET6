using System;
using System.Collections.Generic;

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

            //Console.Write("Zadejte číslo dne: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Název dne v týdnu je: {GetDayName(number)}");

            //int[] numbers = new[] { 10, 11, 12, 13, 20, 67 };

            //// klasicky for s indexem - vim kolikrat se opakuje
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //Console.WriteLine($"index {i}");

            //    Console.WriteLine($"index {i} má hodnostu {numbers[i]}");

            //}

            //// foreach - iterace pres kolekci prvku (pole)
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine($"Teď zpracovávám čslo {number}");
            //}

            //int counter = 0;
            //while(counter < 5)
            //{
            //    counter = counter + 1;
            //}

            //VypisCisel();
            //SectiCisla();

            //Person adam = new Person();

            //adam.FirstName = "Adam";
            //adam.LastName = "Smith";
            //adam.Age = 30;

            //Person alice = new Person();
            //alice.FirstName = "Alice";
            //alice.LastName = "Smith";
            //alice.Age = 36;

            //Person p1 = new Person();
            //p1.FirstName = "John";

            //Person p2 = new Person("Karel", "Nový", 22);

            //Console.WriteLine($"osoba 1 : {p1.ToString()}");
            //Console.WriteLine($"osoba 1 : {p2.ToString()}");

            //Point p = new Point();

            //Console.WriteLine($"{p.ToString()}");

            //try
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    var x = number / 0;
            //    Console.WriteLine($"Zadal jsi číslo {number}");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine($"Nemohu převést řetězec na číslo");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Dělíme nulou");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //var tupleResult = MyTryParse("150");
            //Console.WriteLine(tupleResult.success);
            //Console.WriteLine(tupleResult.value);

            //bool suc;
            //int val;

            //(suc, val) = MyTryParse("150");

            //Point p = Point.GetDefaultPoint();
            //Point p2 = p;

            //Console.WriteLine(p);
            //Console.WriteLine(p2);

            //p2.X = 150;

            //Console.WriteLine(p);
            //Console.WriteLine(p2);


            //Point p = new Point(100, 100);

            //Console.WriteLine(p.Obsah());

            //var p1 = new Point() { X = 10, Y = 20 };

            //var x = p.GetX();
            //p.SetX(-50);

            // array
            int[] pole_intu = new[] { 5, 12, 155, -5268 };

            // list
            List<int> list_intu = new List<int>();

            List<Person> people = new List<Person>();

            var p1 = new Person("Adam", "Smith", 30);
            var p2 = new Person("Jane", "Doe", 45);
            var p3 = new Person("Jan", "Novák", 22);
            var p4 = new Person("Marie", "Dolejší", 18);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            foreach(Person per in people)
            {
                Console.WriteLine(per.ToString());
            }

        }

        static void VypisCisel()
        {
            bool liche = true;
            while (liche == true)
            {
                Console.WriteLine("Zadejte číslo: ");
                int cislo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Číslo je {cislo}");
                if ((cislo % 2) == 0)
                {
                    liche = false;
                }
            }
            Console.WriteLine("Konec");
        }

        static (bool success, int value) MyTryParse(string s)
        {
            return (success: true, value: 10);

            static void SectiCisla()
            {
                Console.WriteLine("Zadejte číslo: ");
                int cislo = 0;
                bool prevodOk = int.TryParse(Console.ReadLine(), out cislo);
                if (prevodOk == false)
                {
                    Console.WriteLine("Nebylo zadáno číslo.");
                    return;
                }
                else
                {
                    int vysledek = 0;

                    for (int i = 1; i < cislo; i++)
                    {
                        vysledek = vysledek + i;
                    }
                    Console.WriteLine($"Výsledek po sečtení všech čísel od 1 do {cislo} je {vysledek}");
                }

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
}
