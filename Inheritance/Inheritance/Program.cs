using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="ilayda"},
                new Customer{FirstName="melisa"},
                new Customer{FirstName="ecem"}

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
       
    }
    class Person
    {
        public int Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
}
