using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal 
    { 
        public void Bark()
        {
            Console.WriteLine("Baking...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.ReadLine();
        }
    }
}
