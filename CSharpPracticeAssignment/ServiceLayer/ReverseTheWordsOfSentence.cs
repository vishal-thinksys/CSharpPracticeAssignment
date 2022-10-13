using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class ReverseTheWordsOfSentence
    {
        private readonly ILogicUtility _logicUtility;

        public ReverseTheWordsOfSentence(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            Console.Write("Original String:\t");
            ConsoleClass.OutputPrintOnConsole($"Reverse String: {_logicUtility.ReverseTheWordsOfSentence(Console.ReadLine()!)}");
        }
    }
}
