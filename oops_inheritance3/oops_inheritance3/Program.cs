using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance3
{
    public class Student
    {
        protected string studentName;
        protected double age;

        public void Sinput()
        {
            Console.Write("Enter Student Name : ");
            studentName = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            age = double.Parse(Console.ReadLine());
        }
    }
    public class Parent : Student
    {
        protected string parentname;
        protected double parentAge;

        public void Pinput()
        {
            Console.Write("Enter Parent Name : ");
            parentname = Console.ReadLine();
            Console.Write("Enter Parent Age : ");
            parentAge = double.Parse(Console.ReadLine());
        }
    }
    public class Course : Parent
    {
        protected string course1;
        protected string course2;

        public void Cinput()
        {
            Console.Write("Enter First Course Name : ");
            course1 = Console.ReadLine();
            Console.Write("Enter Second Course Name : ");
            course2 = Console.ReadLine();
        }

    }
    public class  Mark : Course
    {
        protected double mark1;
        protected double mark2;
        protected double total;

        public void Minput()
        {
            Console.Write("Enter First Course Mark : ");
            mark1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Course Mark : ");
            mark2 = double.Parse(Console.ReadLine());
        }

        public void Total()
        {
            total=mark1 + mark2;
            Console.WriteLine($"Total Mark : {total}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mark mark = new Mark();
            mark.Sinput();
            mark.Pinput();
            mark.Cinput();
            mark.Minput();
            mark.Total();
            Console.ReadLine();
        }
    }
}
