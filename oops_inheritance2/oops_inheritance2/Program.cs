using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_inheritance2
{
    public class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Eating...!");
        }
    }
    public class Mammal : Animal 
    {
        public void Walk()
        {
            Console.WriteLine("Walking....!");
        }
    }
    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Barking....!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Walk();
            dog.Bark();
            Console.ReadLine();
        }
    }
}
