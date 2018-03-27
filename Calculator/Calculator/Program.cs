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
            Console.WriteLine("Please enter a number");

            string firstString = "";
            firstString = Console.ReadLine();
            int firstValue = int.Parse(firstString);

            Console.WriteLine("Please enter a second number");

            string secondString = "";
            secondString = Console.ReadLine();
            int secondValue = int.Parse(secondString);

            Console.WriteLine(firstValue * secondValue);

            Console.ReadLine();
        }
    }
}
