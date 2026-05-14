using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M1
{
    public class BankCustomer
    {

        private static int s_nextCustomerId;

        // add public fields for FirstName, LastName, and CustomerId
        public string FirstName = "Butters";
        public string LastName = "Worth";
        public readonly string CustomerId;

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }


    }
}