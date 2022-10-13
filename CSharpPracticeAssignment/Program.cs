// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using CSharpPracticeAssignment;
using CSharpPracticeAssignment.LogicLayer;
using CSharpPracticeAssignment.ServiceLayer;

int n;
while (true)
{
    n = ConsoleClass.CommonCommandName();
    if (n > 0 && n < 11)
    {
        switch (n)
        {
            case 1:
                PatternPrintUsingTheAlphabet pattern= new PatternPrintUsingTheAlphabet(new LogicUtility());
                pattern.EntryPoint();
                break;
            case 2:
                ReverseTheString reverseTheString= new ReverseTheString(new LogicUtility());
                reverseTheString.EntryPoint();
                break;
            case 3:
                FindTheLongestWord findTheLongestWord= new FindTheLongestWord(new LogicUtility());
                findTheLongestWord.EntryPoint();
                break;
            case 4:
                SumOfThePrimeNo sumOfThePrimeNo= new SumOfThePrimeNo(new LogicUtility());
                sumOfThePrimeNo.EntryPoint();
                break;
            case 5:
                ReverseTheWordsOfSentence reverseTheWordsOfSentence= new ReverseTheWordsOfSentence(new LogicUtility());
                reverseTheWordsOfSentence.EntryPoint();
                break;
            case 6:
                OperationWithTwoNumber operationWithTwoNumber= new OperationWithTwoNumber(new LogicUtility());
                operationWithTwoNumber.EntryPoint();
                break;
            case 7:
                ConvertDecimalToBinary convertDecimalToBinary= new ConvertDecimalToBinary(new LogicUtility());
                convertDecimalToBinary.EntryPoint();
                break;
            case 8:
                NumberOfDaysForThisMonth numberOfDaysForThisMonth= new NumberOfDaysForThisMonth(new LogicUtility());
                numberOfDaysForThisMonth.EntryPoint();
                break;
            case 9:
                FibonacciSeries fibonacciSeries= new FibonacciSeries(new LogicUtility());
                fibonacciSeries.EntryPoint();
                break;
            case 10:
                PalindromeCheck palindromeCheck = new PalindromeCheck(new LogicUtility());
                palindromeCheck.EntryPoint();
                break;
            default:
                break;
        }

    }
    else
    {
        ConsoleClass.OutputPrintOnConsole("You are enter wrong number\n");
    }
}
