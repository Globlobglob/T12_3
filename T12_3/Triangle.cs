using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle
    {
        public int a;
        public int b;
        public int c;



        // public Triangle() { a = 5; b = 10; c = 60; }

        public Triangle(int side)
        {
            this.a = side;
            this.b = side;
            this.c = side;
        }

        public override string ToString()
        {
            return $"side a = {a}\nside b = {b}\nside c = {c}\nP={a*b}";
        }
    }
}
