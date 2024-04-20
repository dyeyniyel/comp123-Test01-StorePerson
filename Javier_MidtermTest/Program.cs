using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier_MidtermTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "store.json";
            
            
            //Showing all the people
            Console.WriteLine($"\nAll people");
            Store.Show();
            
            //Showing the Employeee with salary over 20_000              
            double amount = 20_000;
            Console.WriteLine($"\n\nEmployee with salary over {amount:C}"); 
            Store.Show(amount);

            //Showing a person with matching name
            string name = "Kassie";
            Console.WriteLine($"\nPerson with name { name}:");
            Store.Show(name);

            //Showing all the name longer than 5 letters
            int length = 5;
            Console.WriteLine($"\n\nPeople with name longer than {length} characters:");
            Store.Show(length);
            
            //To saving all transaction to a json file
            Console.WriteLine($"\n\nSaving everyone to file { file}");
            Store.Save(file);

            Console.ReadKey();
        }
    }
}
