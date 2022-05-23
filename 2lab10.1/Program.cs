using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab10._1
{
    /*Функція, яка перевіряє, чи рядок, що передається, має парну кількість слів.
Виняткова ситуація генерується, коли рядок – порожній.*/
    internal class Program
    {
        public static void Main(string[] args)
        {
            Function str = new Function("");
            // func.E1();
            try
            {
                Console.WriteLine(str.E2());
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message + "StackTrace: \n" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\n");
            }
            try
            {
                Console.WriteLine(str.E3());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + " StackTrace: \n" + e.StackTrace);
            }

            finally
            {
                Console.WriteLine("\n");
            }
            try
            {
                Console.WriteLine(str.E4());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "StackTrace: \n" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
