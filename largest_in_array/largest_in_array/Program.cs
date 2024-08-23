using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int largest = num[0];

            foreach (int i in num) {
                if (i > largest) {
                    largest = i;
                }

            }
            Console.WriteLine("Largest is " + largest);
            Console.ReadLine();
        }
    }
}
