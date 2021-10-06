using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person : INamed
    {
        public Person()
        {
            FirstName = "Nezadáno";
            LastName = "Nezadáno";
            //Age = 0;
            HomeAddress = new Address();
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            //Age = age;
            HomeAddress = address;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth) : this(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            //Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        //public int Age { get; }

        public Address HomeAddress { get; set; } = new Address();
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Age()
        {
           return DateTime.Now.Year - DateOfBirth.Year;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return GetFullName() + " " + HomeAddress.City;
        }

        //public void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public void Print() => Console.WriteLine("person: " + GetFullName());
    }
}
