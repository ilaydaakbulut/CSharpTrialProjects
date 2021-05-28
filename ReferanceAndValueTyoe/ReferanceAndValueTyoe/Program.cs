using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueTyoe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);
            Console.WriteLine(number1);


            string[] cities1 = new string[] { "ankara", "adana", "afyon" };
            string[] cities2 = new string[] { "bursa", "balıkesir", "bolu" };
            cities2 = cities1;
            Console.WriteLine(cities2[0]);
            cities2[0] = "istanbul";
            Console.WriteLine(cities2[0]);

            DataTable datatable ;
            DataTable datatable2 = new DataTable();
            datatable = datatable2;
            
            Console.ReadLine();
        }
    }
}
