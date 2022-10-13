using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class ConvertDecimalToBinary
    {
        private readonly ILogicUtility _logicUtility;

        public ConvertDecimalToBinary(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Number to convert:\t");
            int a = Convert.ToInt32(Console.ReadLine());

            ConsoleClass.OutputPrintOnConsole($"Expected Output := {_logicUtility.ConvertDecimalToBinary(a)}");

        }
    }
}
