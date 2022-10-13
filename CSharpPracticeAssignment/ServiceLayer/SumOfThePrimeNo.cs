using CSharpPracticeAssignment.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.ServiceLayer
{
    public class SumOfThePrimeNo
    {
        private readonly ILogicUtility _logicUtility;

        public SumOfThePrimeNo(ILogicUtility logicUtility)
        {
            _logicUtility = logicUtility;
        }
        public void EntryPoint()
        {
            ConsoleClass.OutputPrintOnConsole($"Sum of the first 500 prime numbers: {_logicUtility.SumOfThePrimeNo(500)}");
            
        }
    }
}
