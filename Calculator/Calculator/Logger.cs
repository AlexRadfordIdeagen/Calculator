using System;

using System.IO;

namespace Calculator
{
    public class Logger
    {
        public void Clear()
            {
            File.WriteAllText(@"C:\Users\Alex.Radford\source\Corndel\Calculator", string.Empty);
            }

        public void Log(string question, string answer)
        {
            File.AppendAllText(@"C:\Users\Alex.Radford\source\Corndel\Calculator", string.Format("{0} = {1}{2}", question, answer, Environment.NewLine));
        }
    }
}
