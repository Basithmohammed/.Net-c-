using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops4
{
    class Circle
    {


        public double rad;
        public double area;
        public double perimeter;


        public void Input()
        {
            Console.Write("Enter Radius Value :");
            rad = double.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            area = Math.PI*(rad * rad);
            perimeter = 2 * Math.PI * rad;
        }
        public void Display()
        {
            Console.WriteLine($"Area : {area}\nPerimeter : {perimeter}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.Input();
                c.Calculate();
                c.Display();
                Console.ReadLine();
            }
        }
    }
}
