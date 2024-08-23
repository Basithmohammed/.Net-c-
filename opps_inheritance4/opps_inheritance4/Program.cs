using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps_inheritance4
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...!");
        }
    }

    public class Cat : Animal 
    {
        public void Meow()
        {
            Console.WriteLine("Meow....!");
        }
    }
    public class Dog : Animal
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
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.ReadLine(); 
        }
    }
}
