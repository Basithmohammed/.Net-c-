using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance1
{
    public class Employee
    {
        protected string name;
        protected double salary;
        protected string department;
        protected double bonus;
        protected double net;

        public void Input()
        {
            Console.Write("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Salary : ");
            salary=double.Parse(Console.ReadLine());
            Console.Write("Enter Department : ");
            department=Console.ReadLine();
        }
        
    }
    public class Salary : Employee
    {
        public void Cal()
        {
            if (salary > 50000)
            {
                bonus=salary*0.20;
                net=salary+bonus;
                Console.WriteLine($"Bonus : {bonus}\nNet Salary : {net}");
            }else if(salary>30000){
                bonus = salary * 0.16;
                net = salary + bonus;
                Console.WriteLine($"Bonus : {bonus}\nNet Salary : {net}");
            }else if (salary > 10000)
            {
                bonus = salary * 0.10;
                net = salary + bonus;
                Console.WriteLine($"Bonus : {bonus}\nNet Salary : {net}");
            }
            else
            {
                bonus = salary * 0.02;
                net = salary + bonus;
                Console.WriteLine($"Bonus : {bonus}\nNet Salary : {net}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            salary.Input();
            salary.Cal();
            Console.ReadLine();
        }
    }
}
