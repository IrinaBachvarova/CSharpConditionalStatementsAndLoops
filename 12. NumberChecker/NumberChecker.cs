﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {


            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid input!");

            }
        }
    }
}
