using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class PatternPrintUsingTheAlphabet
    {
        private readonly ILogicUtility _logicUtility;

        public PatternPrintUsingTheAlphabet(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Please Enter The Number of Rows:\t");
            ConsoleClass.OutputPrintOnConsole($"{_logicUtility.DisplayTheRightAngleTrianglePatternUsingTheAlphabet(Convert.ToInt32(Console.ReadLine()), 'A')}");
        }
    }
}
