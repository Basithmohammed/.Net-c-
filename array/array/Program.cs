using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "BMW", "BENZ", "Ferrari" };
            for (int i = 0; i < cars.Length; i++) {
                Console.WriteLine(cars[i]);
            }
            
            Console.ReadLine();
        }
        
    }
}
