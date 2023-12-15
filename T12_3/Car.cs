using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public string model;
        public string name;
        public int num;
        


        public Car() { }

        public Car(string model,string name,int num)
        {
            this.model = model;
            this.name = name;
            this.num = num;
            
           

        }

        public string Start()
        {
            return $"Model-{model}\nMarka-{name}\nNum-{num}\nMode-start";
        }

        public string End() { return $"Model-{model}\nMarka-{name}\nNum-{num}\nMode-stop"; }

    }
}
