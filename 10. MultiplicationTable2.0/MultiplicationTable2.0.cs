using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int product = 0;

            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", number, multiplier, number * multiplier);
                return;
            }
            for (int i = multiplier; i <= 10; i++)
            {
                product = number * multiplier;
                Console.WriteLine("{0} X {1} = {2}", number, multiplier, product);
                multiplier++;
            }

        }
    }
}
