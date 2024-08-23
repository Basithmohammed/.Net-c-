using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Range : ");
            double range=Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= range; i++) { 
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
