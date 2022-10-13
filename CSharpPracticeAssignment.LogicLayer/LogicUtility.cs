using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeAssignment.LogicLayer
{
    public interface ILogicUtility
    {
        string DisplayTheRightAngleTrianglePatternUsingTheAlphabet(int noofLine, char startFrom);
        string ReverseTheString(string inputString);
        string FindTheLongestWord(string inputString);
        long SumOfThePrimeNo(int NoOfPrimeNo);
        string ReverseTheWordsOfSentence(string inputString);
        double OperationWithTwoNumber(double firstNumber, char operation, double secondNumber);
        string ConvertDecimalToBinary(int num);
        string NumberOfDaysForThisMonth(int num);
        string FibonacciSeries(int num);
        string PalindromeCheck(int num);
    }
    public class LogicUtility: ILogicUtility
    {
        public string DisplayTheRightAngleTrianglePatternUsingTheAlphabet(int noofLine,char startFrom)
        {
            int AsciiValue = Convert.ToInt32(startFrom);
            string DisplayPatternUsingTheAlphabet="";

            for (int i = 0; i < noofLine; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    DisplayPatternUsingTheAlphabet += Convert.ToChar(j + AsciiValue).ToString()+" ";
                }

                for (int k = i-1; k >= 0; k--)
                {
                    DisplayPatternUsingTheAlphabet += Convert.ToChar(k + AsciiValue).ToString() + " ";
                }

                DisplayPatternUsingTheAlphabet += "\n";
            }

            return DisplayPatternUsingTheAlphabet;
        }
        public string ReverseTheString(string inputString)
        {
            string outputString="";

            for (int i = inputString.Length; i > 0; i--)
            {
                outputString+= inputString[i-1];
            }

            return outputString;
        }
        public string FindTheLongestWord(string inputString)
        {
            string[] stringArray= inputString.Trim().Split(' ');
            string LongestWord= stringArray[0];

            for (int i = 1; i < stringArray.Length; i++)
            {
                if (LongestWord.Length < stringArray[i].Length)
                {
                    LongestWord = stringArray[i];
                }
            }

            return LongestWord;
        }
        public long SumOfThePrimeNo(int NoOfPrimeNo)
        {
            int countPrimeNo = 2;
            int firstPrimeNo = 2;
            int secondPrimeNo = 3;
            long sumOfPrimeNo = firstPrimeNo + secondPrimeNo;
            for (int i = 4; countPrimeNo < NoOfPrimeNo; i++)
            {
                bool flag=false;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i%j==0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    sumOfPrimeNo += i;
                    countPrimeNo++;
                }
            }
            return sumOfPrimeNo;
        }
        public string ReverseTheWordsOfSentence(string inputString)
        {
            string[] stringArray = inputString.Trim().Split(' ');
            string ReverseSentence = "";

            for (int i = stringArray.Length-1; i >=0; i--)
            {
                ReverseSentence += stringArray[i]+" ";
            }

            return ReverseSentence.Trim();
        }
        public double OperationWithTwoNumber(double firstNumber,char operation,double secondNumber)
        {
            switch (operation)
            {
                case '+':
                    return firstNumber+secondNumber;
                   
                case '-':
                    return firstNumber - secondNumber;
                    
                case 'x':
                    return firstNumber * secondNumber;
                    
                case '*':
                    return firstNumber * secondNumber;
                    
                case '/':
                    return firstNumber / secondNumber;
                    
                default:
                    return 0;
            }
        }
        public string ConvertDecimalToBinary(int num)
        {
            string binary="";
            while(num>0)
            {
                binary += Convert.ToString(num % 2); 
                num /= 2;
            }
            return this.ReverseTheString(binary);
        }
        public string NumberOfDaysForThisMonth(int num)
        {
            if (num>0 && num<13)
            {
                if (num == 2)
                    return "Month have 28/29 days";
                else if (num == 4 || num == 6 || num == 9 || num == 11)
                    return "Month have 30 days";
                else
                    return "Month have 31 days";
            }
            else
                return "Given month no is not correct";
        }
        public string FibonacciSeries(int num)
        {
           int firstnumber=0;
           int secondnumber=1;
            string series = $"{firstnumber}\t{secondnumber}\t";
            int i = 2;
            while (i<num)
            {
                i++;
                int thirdnumber =  firstnumber + secondnumber;
                series += $"{thirdnumber}\t";
                firstnumber = secondnumber;
                secondnumber = thirdnumber;
            }
            return series;
        }
        public string PalindromeCheck(int num)
        {
            int GivenNum = num;
            int PalindromeNum = 0;
            while (num>0)
            {
                PalindromeNum *= 10;
                PalindromeNum += num % 10;                
                num /= 10;
            }
            if (GivenNum == PalindromeNum)
            {
                return $"{GivenNum} is a palindrome number";
            }
            return $"{GivenNum} is not a palindrome number";
        }
       
    }
}
