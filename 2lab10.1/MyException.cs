using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab10._1
{
    public class MyException : Exception
    {
        public MyException(String errorMessage)
        : base(errorMessage) { }
    }
}
