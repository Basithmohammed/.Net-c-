using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_constructors
{
    public class Car
    {
        public string Model;
        public int Year;


        //default constructor 
        //Output will run when we create a method(dont need to call it)
        public Car()
        {
            Model = "Unknown";
            Year = 2000;

        }


        //parameterized Constructor 
        //Argument will pass when we create object
        public Car(string model, int year)
        {
                Model = model;
                Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Model : {Model}\nYear : {Year}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Toyoto",2022);

            car1.Display();
            car2.Display();
            Console.ReadLine();


        }
    }
}
