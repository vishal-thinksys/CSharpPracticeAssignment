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








//    using CSharpPracticeAssignment.LogicLayer;

//ILogicUtility logicUtility = new LogicUtility();


//Console.WriteLine($"{logicUtility.DisplayTheRightAngleTrianglePatternUsingTheAlphabet(5, 'A')}");
//Console.WriteLine($"{logicUtility.ReverseTheString("Welcome hi")}");
//Console.WriteLine($"{logicUtility.FindTheLongestWord(" Write a C# Sharp Program to display the following pattern using the alphabet ")}");

//Console.WriteLine($"{logicUtility.SumOfThePrimeNo(500)}");

//Console.Write("Input first number:\t");
//double a =Convert.ToDouble(Console.ReadLine());
//Console.Write("Input operation:\t");
//char ch = Convert.ToChar(Console.ReadLine()!);
//Console.Write("Input second number:\t");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{decimal.Round(Convert.ToDecimal(logicUtility.OperationWithTwoNumber(a,ch,b)),5)}");
//Console.WriteLine($"{logicUtility.ConvertDecimalToBinary(32)}");
//int i = 0;
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");
//Console.WriteLine($"{logicUtility.NumberOfDaysForThisMonth(i++)}");

//Console.WriteLine($"{logicUtility.PalindromeCheck(121)}");
//Console.WriteLine($"{logicUtility.PalindromeCheck(120)}");
//Console.WriteLine($"{logicUtility.PalindromeCheck(1205)}");
//Console.WriteLine($"{logicUtility.PalindromeCheck(12097)}");

