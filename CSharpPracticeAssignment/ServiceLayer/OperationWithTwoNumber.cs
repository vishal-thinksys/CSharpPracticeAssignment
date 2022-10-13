using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class OperationWithTwoNumber
    {
        private readonly ILogicUtility _logicUtility;

        public OperationWithTwoNumber(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Input first number:\t");
            double a =Convert.ToDouble( Console.ReadLine());

            Console.Write("Input operation:\t");
            char ch =Convert.ToChar(Console.ReadLine()!);

            Console.Write("Input second number:\t");
            double b = Convert.ToDouble(Console.ReadLine());

            ConsoleClass.OutputPrintOnConsole($"Expected Output :\n{a} {ch} {b}= {_logicUtility.OperationWithTwoNumber(a,ch,b)}");

        }
    }
}
