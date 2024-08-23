using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_of_even_and_odd_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = {2,3,1,6,9,10,12,5,7,8,11};
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0) { 
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Even Count = " + evenCount);
            Console.WriteLine( "Odd Count = " + oddCount);
            Console.ReadLine();
        }
    }
}
