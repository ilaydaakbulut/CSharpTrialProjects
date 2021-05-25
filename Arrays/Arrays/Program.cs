using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0]= "engin";
            students[1]= "derin";
            students[2]= "salih";
            string[] students2 = new[] { "engin2" , "derin2","salih2" };
            //new olmasa da olur.
            //students2[3] = "ahmet"; hatalı gösterim
            string[,] regions = new string[5, 3]
            {
                {"istanbul","izmit","balikesir" },
                {"ankara","konya","kırıkkale" },
                {"antalya","adana","mersin" },
                {"rize","trabzon","giresun" },
                {"izmir","mugla","aydın" }
            };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*************");
            }

            Console.ReadLine();

        }
    }
}
