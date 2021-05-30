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
            
            Console.ReadLine();
        }
    }
}
