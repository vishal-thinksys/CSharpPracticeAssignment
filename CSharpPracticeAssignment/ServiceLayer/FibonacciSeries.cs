using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class FibonacciSeries
    {
        private readonly ILogicUtility _logicUtility;

        public FibonacciSeries(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Input number of terms to display :\t");
            int a = Convert.ToInt32(Console.ReadLine());

            ConsoleClass.OutputPrintOnConsole($"Here is the Fibonacci series upto to {a} terms :  {_logicUtility.FibonacciSeries(a)}");
        }
    }
}
