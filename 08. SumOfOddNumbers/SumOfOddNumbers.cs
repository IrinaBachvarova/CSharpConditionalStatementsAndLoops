using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum = i + sum;
                }
                else
                {
                    n++;
                }
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
