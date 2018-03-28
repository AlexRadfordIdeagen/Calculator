using System;

namespace Calculator
{
    public class DateCalculator
    {
        public   void PerformOneDateCalculation()
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
                    string dateLog = answer.ToString();
                    string addLog = addInput.ToString();
                    answer = answer.AddDays(addInput);
                    string answerLog = answer.ToString();
                    Console.WriteLine("The answer is: {0:d}", answer);
                   // new Logger().Log(string.Join(dateLog, " + ", addLog), answerLog);

                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry that didn't work please try again");

                }
            }



        }
    }
}
