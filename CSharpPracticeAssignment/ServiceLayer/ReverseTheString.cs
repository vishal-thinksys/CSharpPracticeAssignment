using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class ReverseTheString
    {
        private readonly ILogicUtility _logicUtility;

        public ReverseTheString(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Please Enter The String:\t");
            ConsoleClass.OutputPrintOnConsole($"Reversed string is: {_logicUtility.ReverseTheString(Console.ReadLine()!)}");
        }
    }
}
