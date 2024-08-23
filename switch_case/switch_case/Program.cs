using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;
            Console.Write("Enter a day(1-7): ");
            int day =Convert.ToInt32(Console.ReadLine());

            switch (day) { 
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;     
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thurday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
