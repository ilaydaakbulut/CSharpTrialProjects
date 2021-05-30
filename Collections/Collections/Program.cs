using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] cities = new string[2] { "Ankara", "istanbul" };
            cities = new string[3];
            cities[2] = "adana";
            Console.WriteLine(cities[0]);
            */

            ArrayList cities = new ArrayList();
            cities.Add("ankara");
            cities.Add("adana");
            cities.Add(1);
            cities.Add('a');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("****************");

            List<string> cities2 = new List<string>();
            cities2.Add("ankara");
            Console.WriteLine(cities2.Contains("ankara"));//true döner

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("******************");
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "ilayda" });
            customers.Add(new Customer { Id = 2, FirstName = "melisa" });
            /*
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "ilayda" },
                new Customer { Id = 2, FirstName = "melisa" }
            };
            */
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "ecem"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id=4,FirstName="ali"},
                new Customer{Id=5,FirstName="ayse"}
            });
            //customers.Clear();//listenin elemanlarını siler.

            var index = customers.IndexOf(customer2); 
            Console.WriteLine("Index : {0} ",index);
            customers.Add(customer2);
            var index2= customers.LastIndexOf(customer2);
            Console.WriteLine("Index2 : {0} ", index2);

            customers.Insert(0,customer2);//istenen indexse sayı eklenir.
            customers.Remove(customer2);
            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "ilayda");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine(count);
            Console.WriteLine("******************");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"] );
            //Console.WriteLine(dictionary["glass"] ); 
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("glass")  ); //false döner
            
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
