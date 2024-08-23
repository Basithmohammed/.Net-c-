using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_constructor1
{
    public class BankAccount
    {
        public string name;
        public double balance;
        public double withdraw;
        public double totalbalance;


        //default constructor (Constructor Name and Class name should be same)

        public BankAccount()
        {
            name = "Mohammed Basith A";
            balance = 2000;
            Console.Write("Enter Withdrawal Amount : ");
            withdraw=double.Parse(Console.ReadLine());

        }
        
        public void Display()
        {
            if (withdraw > balance) 
            {
                Console.WriteLine("You can't proceed");
                Console.WriteLine($"Account Holder Name : {name}\nTry to enter below your balance");
            }
            else
            {
                Console.WriteLine("Transaction Completed Successfully");
                totalbalance = balance - withdraw;
                Console.WriteLine($"Account Holder Name : {name}\nBalance Amount : {totalbalance}");
            }
            
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                BankAccount b =new BankAccount();
                b.Display();
                Console.ReadLine();
            }
        }
    }
}
