using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Info
    {
        public int hours;
        public int minutes;
        public int seconds;
        public Info() { }   

        public Info(int hours,int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;

        }

        public Info(int hours,int minutes,int seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }

        public int getSeconds() 
        {
            return (hours*60*60)+(minutes*60)+seconds;
        
        }

        public override string ToString()
        {
            return getSeconds().ToString();
        }


    }
}
