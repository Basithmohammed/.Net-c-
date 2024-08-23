using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition Result : "+Add(num1 , num2));
            Console.WriteLine("Substraction Result : " + sub(num1, num2));
            Console.WriteLine("Multiplication Result : " + Mul(num1, num2));
            Console.ReadLine();
        }
        static int Add(int num1, int num2) {
            return(num1+num2);      
        }
        static int sub(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int Mul(int num1, int num2)
        {
            return (num1 * num2);
        }

    }
}
