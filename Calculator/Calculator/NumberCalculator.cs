using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class NumberCalculator
    {


        private static int GetNumber(string input)
        {
            while (true)
            {


                string numberString = "";
                int number = 0;
                Console.WriteLine(input);

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

        public static int? AskForOptionalNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return null;
                }

                int number;
                if (int.TryParse(input, out number))
                {
                    return number;
                }
            }
        }
        private static string GetOperatorChar()
        {
            Console.WriteLine("Please enter your operator");
            string operatorString = Console.ReadLine();
            return operatorString;
        }

        public static List<int> GetNumberArray()
        {
            Console.WriteLine("Enter your number");
            List<int> numbers = new List<int>();

            while (true)



            {
                int? number = AskForOptionalNumber("  Please enter the next number: ");

                if (number.HasValue)
                {
                    numbers.Add(number.Value);
                }
                else
                {
                    break;
                }

            }
            return numbers;

        }

        public void PerformOneCalculation()
        {
            string operatorString = GetOperatorChar();
            var numbers = GetNumberArray();
            int answer = numbers[0];

            for (int index = 1; index < numbers.Count; index++)
            {
                switch (operatorString)
                {
                    case "-":
                        answer = numbers.Aggregate((p, next) =>  p - next);

                        break;
                    case "+":
                        answer = numbers.Aggregate((p, next) => next + p);

                        break;
                    case "*":
                        answer = numbers.Aggregate(1, (p, next) => next * p);

                        break;
                    case "/":
                        answer = numbers.Aggregate((p, next) => p / next);
                        break;

                    default:
                        throw new InvalidOperatorException(operatorString);

                }




                //  string num1Log = num1.ToString();
                //  string num2Log = num2.ToString();
                //  string answerLog = answer.ToString();



                // new Logger().Log(string.Join(num1Log, operatorString, num2Log), answerLog);

            }
            Console.WriteLine("The answer is: " + answer);
        }
    }
}


