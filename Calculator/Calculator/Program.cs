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

            Console.WriteLine("How many numbers do you want to " + operatorString + "?");

            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("please enter value " + (i + 1) + " :");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            /*
            Console.WriteLine("Please enter a number");

            string firstString = "";
            firstString = Console.ReadLine();
            int firstValue = int.Parse(firstString);

            Console.WriteLine("Please enter a second number");

            string secondString = "";
            secondString = Console.ReadLine();
            int secondValue = int.Parse(secondString);
            */

            int answer = numbers[0];

            for (int index = 1; index < number; index++)
                if (operatorString == "+")
            {
                    answer = answer+numbers[index];
                
            }

            else if (operatorString == "-")
                {
                    answer = answer-numbers[index];

                }

                else if (operatorString == "/")
                {
                    answer = answer/numbers[index];

                }

                else if (operatorString == "*")
                {
                    answer = answer*numbers[index];

                }


            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
        }
    }
}
