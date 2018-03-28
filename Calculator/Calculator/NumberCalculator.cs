using System;


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
        public  void PerformOneCalculation()
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

            string num1Log = num1.ToString();
            string  num2Log = num2.ToString();
            string answerLog = answer.ToString();
            
            Console.WriteLine("The answer is: " + answer);

            new Logger().Log(string.Join(num1Log, operatorString, num2Log), answerLog);

        }
    }
}

