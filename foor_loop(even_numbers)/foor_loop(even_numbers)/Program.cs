using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foor_loop_even_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Range to find even: ");
            double range = Convert.ToDouble(Console.ReadLine());
            for (int i = 2; i <= range; i+=2)
            {
                Console.WriteLine(i);
            }
            

            Console.Write("Enter a Range to find Odd : ");
            double range1 = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= range1; i += 2)
            {
                Console.WriteLine(i);
            }
            

            Console.Write("Enter a Range to find even: ");
            double range2 = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= range2; i ++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
