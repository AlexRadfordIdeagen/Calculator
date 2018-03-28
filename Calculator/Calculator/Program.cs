using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program

   
    {
        public enum CalculationMode
        {
            NumberCalculator = 1,
            DateCalculator = 2
        }

      //  private  const int NumberCalculator = 1;
        //private  const int DateCalculator = 2;
        

        static void Main(string[] args)


        {
            
            PrintWelcomeMessage();
            
           
            while (true)
            {

                try
                {
                    int calculationMode = AskForCalculationMode();
                    int numCalculator = (int)CalculationMode.NumberCalculator;
                    int dateCalculator = (int)CalculationMode.DateCalculator;
                    if (calculationMode == numCalculator) 
                    {
                        new NumberCalculator().PerformOneCalculation();

                    }
                    else if (calculationMode == dateCalculator)
                    {
                        new DateCalculator().PerformOneDateCalculation();
                    }

                
                }
              
                
                catch (InvalidOperatorException exception)
                {

                    Console.WriteLine(exception.Message + " Please try again");
                    Console.WriteLine();
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
           // new Logger().Clear();
        }
   
    }
    
}
