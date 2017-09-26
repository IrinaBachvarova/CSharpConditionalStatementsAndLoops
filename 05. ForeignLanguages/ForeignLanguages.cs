using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country == "England" || country == "USA" || country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                switch (country)
                {
                    case "England":
                        Console.WriteLine("English");
                        break;

                    case "USA":
                        Console.WriteLine("English");
                        break;

                    case "Spain":
                        Console.WriteLine("Spanish");
                        break;
                    case "Argentina":
                        Console.WriteLine("Spanish");
                        break;
                    case "Mexico":
                        Console.WriteLine("Spanish");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("unknown");
            }
            

            
        }
    }
}
