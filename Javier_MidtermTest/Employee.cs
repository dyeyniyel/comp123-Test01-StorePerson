using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier_MidtermTest
{

    //Employee class inherits from StorePerson class
    public class Employee : StorePerson
    {
        public double Salary { get; }

        //constructor
        public Employee(string name, string cell, double salary = 2500) : base(name, cell)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cell} Salary: {Salary:C}"; //string output. Credit is formatted as currency amount
        }
    }
}
