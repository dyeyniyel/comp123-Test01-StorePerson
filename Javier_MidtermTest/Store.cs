using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Javier_MidtermTest
{
    public static class Store
    {
        private static List<StorePerson> people; //represents the collection of customers and employees associated with this store


        //static constructor
        static Store()
        {
            people = new List<StorePerson>
        {
            new Customer("Gokulraj", "123-4567", 500),
            new Employee("Amy", "123-6789", 2500),
            new Employee("Kassie", "234-5678", 19000),
            new Customer("Yao", "345-6789", 750),
            new Employee("Zhiyang", "456-7890", 29000),
            new Employee("Piyush", "678-9012", 17000),
            new Customer("Hitesh", "890-1234", 400),
            new Employee("Ahsan", "901-2345", 34000),
            new Customer("Wahiba", "123-9012", 750),
            new Employee("Rowel", "456-8901", 24800)
        };
        }

        public static void Show() //method to display all objects
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {people[i].ToString()}");
            }
        }

        public static void Show(string name)  //method to display all objects that matches the name

        {
            int nameCount = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name == name)
                {
                    nameCount++;
                    Console.WriteLine($"{nameCount}. {people[i].ToString()}");
                }
            }
        }

        public static void Show(int length) //method to display all objects that matches the length
        {
            int lengthCount = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name.Length > length)
                {
                    lengthCount++;
                    Console.WriteLine($"{lengthCount}. {people[i].ToString()}");
                }
            }
        }

        public static void Show(double amount) //method to display all objects whose salary exceeds the argument
        {
            int amountCount = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i] is Employee employee && employee.Salary > amount) //checks if the element at index i is an instance of Employee and if the Salary is greater than the specified amount.
                {
                    amountCount++;
                    Console.WriteLine($"{amountCount}. {people[i].ToString()}");
                }
            }
        }

        public static void Save(string filename) //serialize objects
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(people);
            File.WriteAllText(filename, json);
        }
    }
}
