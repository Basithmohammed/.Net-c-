using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public class person
    {
        public string Name;
        public int Age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}\nAge : {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.Name = "John";
            person.Age = 25;
            person.DisplayInfo();
            Console.ReadLine();
        }
    }
}
