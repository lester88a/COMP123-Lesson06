﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 myClass = new Class1("hello");

            myClass.IntegerNumber = 10;
            myClass.DoubleNumber = 50.0;

            myClass.show();

            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}