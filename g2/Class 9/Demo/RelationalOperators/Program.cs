﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Box b1 -----------");
            Box b1 = new Box(5, 5, 5);
            b1.PrintBox();

            Console.WriteLine("----------- Box b2 -----------");
            Box b2 = new Box(3, 3, 3);
            b2.PrintBox();

            Console.WriteLine("\n----------- b1 == b2 Operator -----------");
            Console.WriteLine($"b1 == b2: {b1 == b2}");

            Console.WriteLine("\n----------- b1 != b2 Operator -----------");
            Console.WriteLine($"b1 != b2: {b1 != b2}");

            Console.WriteLine("\n----------- b1 > b2 Operator -----------");
            Console.WriteLine($"b1 > b2: {b1 > b2}");

            Console.WriteLine("\n----------- b1 < b2 Operator -----------");
            Console.WriteLine($"b1 < b2: {b1 < b2}");

            Console.WriteLine("\n----------- b1 >= b2 Operator -----------");
            Console.WriteLine($"b1 >= b2: {b1 >= b2}");

            Console.WriteLine("\n----------- b1 <= b2 Operator -----------");
            Console.WriteLine($"b1 <= b2: {b1 <= b2}");

            Console.ReadLine();
        }
    }
}
