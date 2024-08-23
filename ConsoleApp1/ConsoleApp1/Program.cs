using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 12;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a-b); 
            //Console.ReadLine();

            Console.Write("Enter First Number : ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
