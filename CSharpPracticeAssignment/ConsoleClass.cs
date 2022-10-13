using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment
{
    public class ConsoleClass
    {
        public static int CommonCommandName()
        {
            int n;
            Console.WriteLine("\nPress 1  Display Pattern Using The Alphabet:");
            Console.WriteLine("Press 2  Print String In Reverse Order (don't use built in Reverse method):");
            Console.WriteLine("Press 3  Find The Longest Word In String:");
            Console.WriteLine("Press 4  Compute The Sum Of The First 500 Prime Numbers:");
            Console.WriteLine("Press 5  Reverse The Words Of Sentence:");
            Console.WriteLine("Press 6  Takes Two Numbers As Input And Perform An Operation:");
            Console.WriteLine("Press 7  Convert Decimal To Binary:");
            Console.WriteLine("Press 8  Find The Number Of Days In Month:");
            Console.WriteLine("Press 9  The First n Terms Of Fibonacci Series:");
            Console.WriteLine("Press 10 Check Whether A Number Is A Palindrome Or Not:");
            Console.Write("\nPlease Enter the Number:\t");
            bool isNumerical = int.TryParse(Console.ReadLine(), out n);
            n = isNumerical ? n : 0;
            return n;
        }
        public static void OutputPrintOnConsole(string text)
        {
            Console.WriteLine($"\n{text}");
        }
    }
}
