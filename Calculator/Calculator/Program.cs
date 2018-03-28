using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;


        static void Main(string[] args)


        {

            PrintWelcomeMessage();
           
            while (true)
            {
                
                int calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    PerformOneCalculation();
                    
                }
                else
                {
                    PerformOneDateCalculation();
                }
           

            }
         

        }

        private static void PerformOneDateCalculation()
        {
            while (true)
            {
                Console.WriteLine("Please enter a date:");

                string input = Console.ReadLine();
                DateTime answer;
                if (DateTime.TryParse(input, out answer))
                {
                    Console.WriteLine("Please enter the number of days to add:");
                    int addInput = int.Parse(Console.ReadLine());
                    answer = answer.AddDays(addInput);
                    Console.WriteLine("The answer is: {0:d}", answer);
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry that didn't work please try again");

                }
            }
           
  

        }

        private static int AskForCalculationMode()
        {
            int answer;
            Console.WriteLine("Which calculator mode do you want?");
            Console.WriteLine(" 1) Numbers");
            Console.WriteLine(" 2) Dates");
            answer = int.Parse(Console.ReadLine());
            return answer;

            
        }

        /*

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


 Console.WriteLine("Please enter a number");

 string firstString = "";
 firstString = Console.ReadLine();
 int firstValue = int.Parse(firstString);

 Console.WriteLine("Please enter a second number");

 string secondString = "";
 secondString = Console.ReadLine();
 int secondValue = int.Parse(secondString);


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

*/



        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");
        }

        private static int GetNumber(string input)
        {
            while (true)
            {


                string numberString = "";
                int number = 0;
                Console.WriteLine("Input your " + input + " number");

                numberString = Console.ReadLine();
                if (int.TryParse(numberString, out number))
                {
                    

                    return number;

                }

                else
                {
                    Console.WriteLine("I'm sorry that didn't work please enter an integer");

                }

            }


        }

        private static string GetOperatorChar()
        {
            Console.WriteLine("Please enter your operator");
            string operatorString = Console.ReadLine();
            return operatorString;
        }
        private static void PerformOneCalculation()
        {
            string operatorString = GetOperatorChar();
            int num1 = GetNumber("first");
            int num2 = GetNumber("second");
            int answer = 0;

            if (operatorString == "+")
            {
                answer = num1 + num2;

            }

            else if (operatorString == "-")
            {
                answer = num1 - num2;

            }

            else if (operatorString == "/")
            {
                answer = num1 / num2;

            }

            else if (operatorString == "*")
            {
                answer = num1 * num2;

            }

            Console.WriteLine("The answer is: " + answer);
        }
    }
}
