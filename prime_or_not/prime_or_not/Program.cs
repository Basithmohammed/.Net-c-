using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            prime(num);
            Console.ReadLine();

        }
        static int prime(int num)
        {
            if (num > 1)
            {
                for (int i = 2; i < (num / 2) + 1; i++)
                {
                    if ((num % i) == 0)
                    {
                        Console.WriteLine(num+" is not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(num + " is a prime number");
                        break ;
                    }
                }
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
            return num;
        }
    }
}
