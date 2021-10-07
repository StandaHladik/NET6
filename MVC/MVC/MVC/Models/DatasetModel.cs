﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Obecně nazýváno Model zde v namespace Dataset, může sdružovat více tříd
namespace Dataset.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Address HomeAddress { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public int Age()
        {
            if (DateOfBirth.HasValue)
            {
                return DateTime.Now.Year - DateOfBirth.Value.Year;
            }
            else
            {
                throw new ArgumentException("DateOfBirth is null");
            }
        }

        public double AccountSum()
        {
            return Transactions.Sum(x => x.Value);         

            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {HomeAddress.Street}, {HomeAddress.City}";
        }


    }
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public string City { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public TransactionType Type { get; set; }

        /// <summary>
        /// Debetni operace jsou zaporne hodnoty (odchozí)
        /// Kreditni operace jsou kladne (příchozí)
        /// </summary>
        public double Value { get; set; }

    }

    public enum TransactionType
    {     
        // Description
        [Description("Debetní operace (odchozí)")]
        DEBIT,
        [Description("Kreditní operace (příchozí)")]
        CREDIT,
        [Description("Ostatní operace")]
        OTHER
    }
}
