using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator__switch_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose Operator : ");
            string op=Console.ReadLine();

            switch (op) {
                case "+":
                    double sum = num1 + num2;
                    Console.WriteLine("Sum : " + sum);
                    break;
                case "-":
                    double sub = num1 - num2;
                    Console.WriteLine("Sum : " + sub);
                    break;
                case "*":
                    double mul = num1 * num2;
                    Console.WriteLine("Sum : " + mul);
                    break;
                case "/":
                    double div = num1 / num2;
                    Console.WriteLine("Sum : " + div);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();

        }
    }
}
