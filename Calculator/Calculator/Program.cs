using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");
            Console.WriteLine("Please enter the operator: ");

            string operatorString = Console.ReadLine();
            

            Console.WriteLine("Please enter a number");

            string firstString = "";
            firstString = Console.ReadLine();
            int firstValue = int.Parse(firstString);

            Console.WriteLine("Please enter a second number");

            string secondString = "";
            secondString = Console.ReadLine();
            int secondValue = int.Parse(secondString);

            if (operatorString == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }

            else if (operatorString == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }

            else if (operatorString == "/")
            {
               
                Console.WriteLine(firstValue / secondValue);
            }

            else if (operatorString == "*")
            {
                
                Console.WriteLine(firstValue * secondValue);
            }

            else
            {
                Console.WriteLine("I'm sorry the operator you entered didn't work please try again");
            }

            Console.ReadLine();
        }
    }
}
