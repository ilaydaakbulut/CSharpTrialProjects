using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            Console.WriteLine(number == 10 ? "number is 10" : "number is not 10" );
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }
        }
    }
}
