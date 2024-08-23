
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {





            int secret = 11; 
            int guess = 0;

            while (guess != secret)
            {
                Console.WriteLine("Enter Your Guess : ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < secret)
                {
                    Console.WriteLine("Your Guess is Low.. Try Again.");
                    
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Your Guess is High... Try Again");
                    
                }
            }
            Console.WriteLine("Your Guess is right");
            Console.ReadLine();
            }
        }
    }

