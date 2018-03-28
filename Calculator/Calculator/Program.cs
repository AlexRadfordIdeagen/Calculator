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
                    new NumberCalculator().PerformOneCalculation();
                    
                }
                else
                {
                   new DateCalculator().PerformOneDateCalculation();
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


        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");
            new Logger().Clear();
        }
   
    }
    
}
