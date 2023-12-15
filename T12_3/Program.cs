using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double num1=double.Parse(Console.ReadLine());
            //double num2=double.Parse(Console.ReadLine());

            //Class val = new Class(num1,num2);
            //Console.WriteLine(val.GetValue());

            //Info getsec = new Info(2,30,60);
            //Console.WriteLine(getsec.ToString());


            Triangle prime = new Triangle(20);
            Console.WriteLine(prime.ToString());

            Car car = new Car("Vaz","220",892);
            Console.WriteLine(car.Start());


            Car car1= new Car("Vaz", "220", 892);
            Console.WriteLine(car1.End());


            Journal j1 = new Journal();
            j1.Init("Journal", 56, 20);
            j1.Info();
            j1.ChangeName("Maxim");
            j1.ChangeNumber(1);
            Console.ReadLine();




        }
    }
}
