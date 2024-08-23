using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Number 1 : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Number 2 : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Addition : "+(a+b));
            //Console.WriteLine("Substraction : " + (a - b));
            //Console.WriteLine("Multiplication : " + (a * b));
            //Console.WriteLine("Division : " + (a / b));
            //Console.ReadLine();





            //Console.Write("Enter Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a > 9)
            //{
            //    Console.WriteLine("Number is greater than 9");
            //}else if (a < 0)
            //{
            //    Console.WriteLine("Number is less than 0");
            //}
            //else 
            //    {
            //    Console.WriteLine("Number is less than 9");
            //}
            //Console.ReadLine();


            Console.Write("Enter Name : ");
            String n = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Height : ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Wight : ");
            double w = Convert.ToDouble(Console.ReadLine());
            double height = h * 0.01;
            double bmi = w / (height*height);

            if (bmi < 18.5)
            {
                Console.WriteLine("Mr/Ms " + n +"\nYour BMI is : "+bmi+"\nYou are Under Weight");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Mr/Ms " + n + "\nYour BMI is : " + bmi + "\nYou are Normal Weight");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Mr/Ms " + n + "\nYour BMI is : " + bmi + "\nYou are Over Wight");
            }
            else 
            {
                Console.WriteLine("Mr/Ms "+n + "\nYour BMI is : " + bmi + "\nYou are Obese");
            }
            Console.ReadLine();
        }
    }
}
