using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class FindTheLongestWord
    {
        private readonly ILogicUtility _logicUtility;

        public FindTheLongestWord(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Please Enter The String:\t");
            ConsoleClass.OutputPrintOnConsole($"Output: {_logicUtility.FindTheLongestWord(Console.ReadLine()!)}");
        }
    }
}
