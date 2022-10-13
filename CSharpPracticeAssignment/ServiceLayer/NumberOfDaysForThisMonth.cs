using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class NumberOfDaysForThisMonth
    {
        private readonly ILogicUtility _logicUtility;

        public NumberOfDaysForThisMonth(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Enter The Month Number:\t");
            int a = Convert.ToInt32(Console.ReadLine());

            ConsoleClass.OutputPrintOnConsole($"Expected Output := {_logicUtility.NumberOfDaysForThisMonth(a)}");
        }
    }
}
