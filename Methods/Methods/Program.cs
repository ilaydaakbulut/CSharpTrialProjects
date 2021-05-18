using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result= Add2(2, 5);
            Console.WriteLine(result);
            int number1 = 10;
            int number2 = 20;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,3));
            Console.WriteLine(Add4(1,2,3,4,5,6));
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1,int number2=30)
        {
            return number1 + number2;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 100;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2*number3;
        }
        static int Add4(int number ,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
