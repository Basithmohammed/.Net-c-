using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class student
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Name : {_name}\nAge : {_age}");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Name = "abin";
            s.Age = 10;
            s.Display();
            Console.ReadLine();
        }
    }
}
