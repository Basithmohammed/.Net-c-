using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 32, 45, 11, 4, 66, 23, 43};
            int temp;
            for(int j=0; j<array.Length; j++)
            {
                for (int i = 0; i < array.Length- 1; i++)
                {

                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }

                }
            }
            Console.WriteLine("Sorted array is : ");
            foreach (int k in array)
            {
                
                Console.WriteLine(k);
            }
           
            Console.ReadLine();

        }
    }
}
