using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Multiplent : ");
            int Num= Convert.ToInt32(Console.ReadLine());
            Console.Write("How Much Limit you need : ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++) { 
                Console.WriteLine(Num + "*" + i + "=" + Num*i);
            
            }
            Console.ReadLine();

        }
    }
}
