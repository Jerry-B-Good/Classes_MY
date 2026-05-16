using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M1
{
    public class BankRobber
    {
        
        private static int s_nextCustomerId;

        // add public fields for FirstName, LastName, and CustomerId
        public string FirstName = "Butters";
        public string LastName = "Worth";
        public readonly string CustomerId;

        public BankRobber(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

    }
}