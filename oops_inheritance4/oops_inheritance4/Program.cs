using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance4
{
    public class College
    {
        protected string CollegeName;
        protected double CollegeId;

        public void Cinput()
        {
            Console.Write("Enter College Name : ");
            CollegeName = Console.ReadLine();
            Console.Write("Enter College Id : ");
            CollegeId=double.Parse(Console.ReadLine());
        }
    }
    public class Teacher : College
    {
        protected string TeacherName;
        protected double TeacherId;

        public void Tinput()
        {
            Console.Write("Enter Teacher Name : ");
            TeacherName = Console.ReadLine();
            Console.Write("Enter Teacher Id : ");
            TeacherId = double.Parse(Console.ReadLine());
        }
    }

    public class Student : College
    {
        protected string StudentName;
            protected double StudentId;

        public void Sinput()
        {
            Console.Write("Enter Student Name : ");
            StudentName = Console.ReadLine();
            Console.Write("Enter Student Id : ");
            StudentId = double.Parse(Console.ReadLine());
        }
    }

    public class otherStaff : College
    {
        protected string otherStaffName;
            protected double otherStaffId;

        public void Oinput()
        {
            Console.Write("Enter otherStaff Name : ");
            otherStaffName = Console.ReadLine();
            Console.Write("Enter otherStaff Id : ");
            otherStaffId = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"College Name : {CollegeName}\nCollege ID : {CollegeId}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Cinput();
            s.Sinput();

            Teacher t = new Teacher();
            t.Cinput();
            t.Tinput();

            otherStaff otherStaff = new otherStaff();
            otherStaff.Cinput();
            otherStaff.Oinput();
            otherStaff.Display();


            Console.ReadLine();
        }
    }
}
