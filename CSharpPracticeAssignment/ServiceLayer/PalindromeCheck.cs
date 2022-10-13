using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class PalindromeCheck
    {
        private readonly ILogicUtility _logicUtility;

        public PalindromeCheck(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            
            Console.Write("Input a number:\t");
            int a = Convert.ToInt32(Console.ReadLine());

            ConsoleClass.OutputPrintOnConsole($"Expected Output :\n {_logicUtility.PalindromeCheck(a)}");

        }
    }
}
