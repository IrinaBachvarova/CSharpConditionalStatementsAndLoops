using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Please write an odd number.");
                    }
                    else
                    {
                        Console.WriteLine("The number is: {0}", number);
                        return;
                    }
                }

                if (number < 0)
                {
                    number = Math.Abs(number);

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Please write an odd number.");
                    }
                    else
                    {
                        Console.WriteLine("The number is: {0}", number);
                        return;
                    }

                }

                
           	
            }
        }
    }
}
