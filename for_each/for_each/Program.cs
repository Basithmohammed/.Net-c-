using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bazi", "Bazith", "Basi" };

            foreach (string name in names)
            { 
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
