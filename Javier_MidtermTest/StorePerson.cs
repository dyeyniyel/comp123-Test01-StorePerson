using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier_MidtermTest
{
    public abstract class StorePerson
    {
        protected static int ID = 100_000;

        public string Cell { get; }
        public string Name { get; }
        public string Id { get; }

        //constructor
        public StorePerson(string name, string cell)
        {
            Name = name;
            Cell = cell;
            Id = ID.ToString(); // Assigns string version of the static field ID
            ID++; // Increments the static field ID for the next object
        }
    }
}
