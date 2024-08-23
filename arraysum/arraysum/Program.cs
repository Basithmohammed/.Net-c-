using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3,4 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                
            }
            Console.WriteLine("Sum of array is "+sum);
            Console.ReadLine();
        }
    }
}
