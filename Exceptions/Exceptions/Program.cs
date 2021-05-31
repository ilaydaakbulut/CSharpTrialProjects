using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try//bunu yapmayı dene
            {
                string[] students = new string[3] { "ilayda", "melisa", "ecem" };
                students[3] = "ali";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)//hata alınırsa bu kısım çalıssın ve exception parametresie aktarılsın
            {                             
                Console.WriteLine(exception.InnerException); //varsa daha detaylı bilgi verir               
            }
            
            try
            {
                List<string> students2 = new List<string> { "melisa", "ecem", "ilayda" };

                if (!students2.Contains("ahmet"))
                {
                    throw new RecordNotFoundException("record not found");
                }
                else
                {
                    Console.WriteLine("record foud");
                }
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }
    }
}
