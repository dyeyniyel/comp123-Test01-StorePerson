using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier_MidtermTest
{
    //customer class inherits from StorePerson class
    public class Customer : StorePerson
    {
        public double Credit { get; }

        //constructor
        public Customer(string name, string cell, double credit = 500) : base(name, cell)
        {
            Credit = credit;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cell} Credit: {Credit:C}"; //string output. Credit is formatted as currency amount
        }
    }
}
