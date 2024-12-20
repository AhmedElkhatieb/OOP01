using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session01_Demo
{
    internal struct Point
    {
        //Attributes
        public int X;
        public int Y;
        
        // constructor is a special function
        // 1- Named always after the name of class or struct
        // 2- Has no return

        // By default at struct, compiler will generate the paramaterless constructor
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public override string ToString()
        {
            return $"The X = {X}, The Y = {Y}";
        }
    }
}
