using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops3
{
    class employee
    {

        public string name;
        public int phone;
        public double salary;
        public double bonus;
        public double netsalary;
        

       
        public void Calculate()
        {
            if (salary >= 50000) { 
                bonus = salary*0.50;
                netsalary = salary + bonus;
            }else if (salary >= 40000)
            {
                bonus = salary * 0.40;
                netsalary = salary + bonus;
            }
            else if (salary >= 30000)
            {
                bonus = salary * 0.30;
                netsalary = salary + bonus;
            }
            else
            {
                bonus = salary * 0.10;
                netsalary = salary + bonus;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Name : {name}\nPhone : {phone}\nSalary : {salary}\nBonus : {bonus}\nNetSalary : {netsalary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e= new employee();
            Console.Write("Enter Employee Name : ");
            e.name = Console.ReadLine();
            e.phone = 1234567890;
            e.salary = 50000;
            e.Calculate();
            e.Display();
            Console.ReadLine();
        }
    }
}
