using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Journal
    {
        public string name;
        public int val;
        public int stripe;

        public Journal() { }
        public void Init(string name,int val,int stripe)
        { 
            this.name = name;
           this.val = val;
            this.stripe = stripe;
        
        }
        public void Info()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Тираж: {val}");
            Console.WriteLine($"Количество полос: {stripe}");
            
        }

        public void ChangeName(string newName)
        {
           name = newName;
        }

        public void ChangeNumber(int newstripe)
        {
            stripe = newstripe;
        }


    }
}
