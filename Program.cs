﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enetr your name!");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "! \nThanks for providing your name!");

            Console.ReadKey();
           
        }
    }
}
