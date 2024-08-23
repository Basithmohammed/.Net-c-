using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Count : ");
            double count=Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {

                for (int k = i; k <= count; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
             }
            


            Console.Write("Enter Count : ");
            double count1 = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < count1; i++)    //outer loop for number of rows
            {
                for (int k = 10 ; k > i + 1; k--)     //nested loop for number of spaces
                {
                    Console.Write(" ");     //printing spaces
                }
                for (int j = 0; j <= i * 2; j++)     //nested loop for printing stars
                {
                    Console.Write("*");      //printing stars
                }
                Console.Write("\n");     //printing newline
            }
        
        Console.ReadLine();
        }
    }
    
}
