using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_and_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Physics Mark (In 50) : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Chemistry Mark (In 50) : ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Biology Mark (In 50) : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Maths Mark (In 50) : ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Computer Mark (In 50) : ");
            double com = Convert.ToDouble(Console.ReadLine());
            double total=p+c+b+m+com;
            double percentage = (total/250)*100;
            Console.WriteLine("Total Mark " + total);
            Console.WriteLine("Percentage is " + percentage);
            if (percentage > +90) {
                Console.WriteLine("Grade A");
            }else if (percentage >= 80)
            {
                Console.WriteLine("Grade B");
            }else if(percentage >= 70)
            {
                Console.WriteLine("Grade C");
            }else if (percentage >= 60)
            {
                Console.WriteLine("Grade D");
            }else if( percentage >= 40)
            {
                Console.WriteLine("Grade E");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
            
            Console.ReadLine();
            

            
        }
    }
}
