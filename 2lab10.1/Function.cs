using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab10._1
{
    public class Function
    {
        private string abc;
        public Function(string abc)
        {
            this.abc = abc;
        
        }

        public double E1()
        {
            var arr = abc.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length ==0)
            {
                Console.WriteLine("string is empty");
                Environment.Exit(1); // вихід з програми з кодом 1
            }
            Console.WriteLine("Кілкість слів = {0}", arr.Length);
            return 0;
        }
        public double E2()
        {
            var arr = abc.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 0)
            {
                throw new MyException("string is empty");
            }
            Console.WriteLine("Кілкість слівв = {0}", arr.Length);
            return 0;
        }
        public double E3()
        {
            var arr = abc.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 0)
            {
                throw new ArgumentNullException();
            }
            Console.WriteLine("Кілкість слів = {0}", arr.Length);
            return 0;
        }
        public double E4()
        {
            var arr = abc.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 0)
            {
                throw new Exception("string is empty");
            }
            Console.WriteLine("Кілкість слів = {0}", arr.Length);
            return 0;
        }

    }
}
