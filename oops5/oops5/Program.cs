using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops5
{
    class Product
    {


        public string pname;
        public double price;
        public double quantity;
        public double totalprice;


        public void Input()
        {
            Console.Write("Enter product name : ");
            pname = Console.ReadLine();
            Console.Write("Enter Product Price : $");
            price = double.Parse(Console.ReadLine());
            Console.Write("Enter Quantity : ");
            quantity = double.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            totalprice = price * quantity;
        }
        public void Display()
        {
            Console.WriteLine($"Total Bill Price : ${totalprice}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Product p = new Product();
                p.Input();
                p.Calculate();
                p.Display();
                Console.ReadLine();
            }
        }
    }
}
