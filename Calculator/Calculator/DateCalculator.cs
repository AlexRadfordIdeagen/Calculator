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
    }
}
