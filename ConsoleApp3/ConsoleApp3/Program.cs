using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Basith";
            int age = 25;
            double height = 172;
            char grade = 'A';
            bool isStudent = true;
            double mark = 35.6;
            int mmark=(int) mark;//float to integer
            double aage = age;

            int a = 10;
            int b = 20;
            int sum = a + b;

            Console.WriteLine("Name :" + name + " Age " + age + "Height " + height + "Grade " + grade + "Is Student? " + isStudent + "Mark " + mark);

            Console.WriteLine($"Name : {name}\n Age : {age}\n Height : {height}\n Grade : {grade}");

            Console.Write(mmark);

            Console.WriteLine($"Sum :" + sum);

            Console.ReadLine();
        }
    }
}
