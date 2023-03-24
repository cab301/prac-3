using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Number { get; }

        public Customer(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public override string? ToString()
        {
            return string.Format("{0} \t\t {1} \t\t {2}",
                FirstName, LastName, Number);
        }
    }
}
