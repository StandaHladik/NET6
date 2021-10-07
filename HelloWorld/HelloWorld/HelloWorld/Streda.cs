using Dataset;
using Dataset.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Streda
    {

        public void Main()
        {
            //int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            ///// z "numbers" zjistěte:
            ///// 1. počet prvků v poli
            //var count = numbers.Count();
            //Console.WriteLine("počet prvků v poli " + count);

            ///// 2. největší hodnotu
            //var max = numbers.Max();
            //Console.WriteLine("největší hodnota " + max);

            ///// 3. nejmenší hodnotu
            //var min = numbers.Min();
            //Console.WriteLine("nejmenší hodnota " + min);

            ///// 4. průměr
            //var average = numbers.Average();
            //Console.WriteLine("průměr " + average);

            ///// 5. kolik obsahuje pole kladných čísel
            //var count_positive = numbers.Where(x => x >= 0).Count();
            //Console.WriteLine("kladných čísel " + count_positive);

            ///// 6. kolik obsahuje pole záporných čísel
            //var count_negative = numbers.Where(x => x < 0).Count();
            //Console.WriteLine("záporných čísel " + count_negative);

            ///// 7. sumu všech hodnot
            //var sum = numbers.Sum();
            //Console.WriteLine("suma: " + sum);

            ///// 8. sumu kladných hodnot
            //var sum_positive = numbers.Where(x => x >= 0).Sum();
            //Console.WriteLine("suma kladnych: " + sum_positive);

            //////// projection / restrikce / filtrovani - Where

            ///// 9. všechna čísla větší než -500
            ////var result = numbers.Where(x => x > -500);

            ///// 10. všechna kladná sudá čísla
            ////var result = numbers.Where(x => x >= 0)
            ////                    .Where(x => x % 2 == 0);

            ///// 11. čísla v rozsahu -400 až 400
            //var result = numbers.Where(x => x > -400 && x < 400);

            //var spojene = string.Join(", ", result);
            //Console.WriteLine("vysledek: " + spojene);

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            // nacti klienty z XML
            var clients = Data.LoadFromXML();

            // pocet klientu
            //Console.WriteLine(clients.Count());

            // select a where
            //var result = clients
            //                .Where(c => c.Age() > 50)
            //                //.Select(c => c.FirstName + " " + c.LastName);    
            //                //.Select(c => c.Transactions);
            // anonymni trida
            //                .Select(c => new { c.FirstName, c.LastName });

            // group by
            //var result = clients.GroupBy(client => client.HomeAddress.City);


            //var result = clients.Select(client => client.FirstName);

            // vypis vsech
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"město: {item.Key} - počet lidí: {item.Count()}");
            //}

            //Client nejstarsi = clients.OrderByDescending(c => c.Age()).First();

            //Console.WriteLine($"Nejstarší klient: {nejstarsi.FirstName} {nejstarsi.LastName}");

            //Client nejmladsi = clients.OrderBy(c => c.Age()).First();

            //Console.WriteLine($"Nejmladší klient: {nejmladsi.FirstName} {nejmladsi.LastName}");

            //Client nejbohatsi = clients.OrderByDescending(c => c.AccountSum()).First();

            //Console.WriteLine(nejbohatsi.FirstName);

            //Client nejchudsi = clients.OrderBy(c => c.AccountSum()).First();

            //Console.WriteLine(nejchudsi.FirstName);

            var result = clients.GroupBy(x => x.HomeAddress.City)
                                .Select(g => new
                                {
                                    Mesto = g.Key,
                                    Client = g.OrderByDescending(y => y.AccountSum()).First()
                                });

            foreach (var item in result)
            {
                Console.WriteLine($"mesto: {item.Mesto}, nejbohatsi klient: {item.Client.FirstName} {item.Client.LastName}, account sum: {item.Client.AccountSum()}");
            }

            var result2 = clients.GroupBy(client => client.HomeAddress.City);

            var olomouc = result2.Where(x => x.Key == "Olomouc").First();

            Console.WriteLine("Nejbohatší");
            foreach (var item in result2)
            {
                Client nejbohatsi = clients.Where(c => c.HomeAddress.City == item.Key)
                                           .OrderByDescending(c => c.AccountSum()).First();
                Console.WriteLine($"{nejbohatsi} {nejbohatsi.AccountSum()}");
            }
            Console.WriteLine();
            Console.WriteLine("Nejchudší");
            foreach (var item in result2)
            {
                Client nejchudsi = clients.Where(c => c.HomeAddress.City == item.Key)
                                           .OrderBy(c => c.AccountSum()).First();
                Console.WriteLine($"{ nejchudsi} { nejchudsi.AccountSum()}");
            }

            // group by to dictionary
            Dictionary<string, List<Client>> dict = clients
                .GroupBy(o => o.HomeAddress.City)
                .ToDictionary(g => g.Key, g => g.ToList());

            var vsichni_plnoleti1 = clients.All(c => c.Age() > 18);

            var vsichni_plnoleti2 = clients.Any(c => c.Age() > 18);

            //var r1 = clients.Union(olomouc);

            //var r2 = clients.Join();

        }

        static List<Person> LoadPeople(string file)
        {
            List<Person> people = new List<Person>();
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                // FirstName;LastName;Age
                string[] items = line.Split(';');

                var first_name = items[0];
                var last_name = items[1];
                var age = int.Parse(items[2]);

                var p = new Person(first_name, last_name);
                people.Add(p);
            }
            return people;
        }

        static void TuplesAndExceptions()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                var x = number / 0;
                Console.WriteLine($"zadal jsi číslo {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nemohu převést řetězec na číslo");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("dělíme nulou");
            }

            bool succ;
            int val;

            // ulozeni tuplu to Tuple typu
            var tupleResult = MyTryParse("150.0");
            succ = tupleResult.Item1;
            val = tupleResult.Item2;

            // ulozeni tuplu to Tuple typu - pojmenovane itemy
            tupleResult = MyTryParse("150.0");
            succ = tupleResult.success;
            val = tupleResult.value;

            // rozlozeni tuplu primo do promennych
            (succ, val) = MyTryParse("150.0");

        }

        static (bool success, int value) MyTryParse(string input)
        {
            return (success: true, value: 10);
        }

        private static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        private static void Interfaces()
        {
            //Student st = new Student() { Name = "Student Pepa" };
            //Teacher teacher = new Teacher() { Name = "Učitel Marek" };
            //Person person = new Person() { Name = "Osoba" };

            INamed st = new Student() { Name = "Student Pepa" };
            INamed teacher = new Teacher() { Name = "Učitel Marek" };
            INamed person = new Person() { Name = "Osoba" };

            PrintName(st);
            PrintName(teacher);
            PrintName(person);
        }
        private static void PrintName(INamed item)
        {
            item.Print();
        }

    }
}
