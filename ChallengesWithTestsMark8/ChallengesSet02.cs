using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           if ( vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else { return true; }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public static int Sum(int[] numbers)
        {
            var Sum = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            foreach(var number in numbers)
            {
                Sum += number;                
            }
            return Sum;
                    
            

        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            int answer = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                     answer += i;                                       
                }                
            }
            return answer;
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
           
            int answer = 0;
            foreach( int i in numbers)
            {
                answer += i;
            }
            if ( answer % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else 
            {
                return number / 2;
            }
        }
    }
}
