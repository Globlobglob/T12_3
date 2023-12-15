using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class
    {

        public double val1;
        public double val2;
         public Class() { }
        public Class(double val1, double val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
         public string GetValue()
        {
            return $"Sqrt={Math.Sqrt(val1 * val2)}";
        }


    }
}
