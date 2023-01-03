using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           return numbers.Where(x => x % 2  == 0).Sum() - numbers.Where(x => x % 2 == 1).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var answer = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return answer.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           var answer = new List<int> { number1, number2, number3, number4 };
            return answer.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            while (sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength2 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            { return true; }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            var answer= double.TryParse(input, out double number);
            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var howmuch = objs.Length;
            var maximum = (howmuch / 2) + 1;
            var start = 0;
            foreach(var obj in objs)
            {
                if(obj == null)
                {
                    start++;
                }
            }
            if (start >= maximum) { return true; }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = new List<int>(0);
            if(numbers == null) { return 0; }
            
            
            foreach(int number in numbers)
            {
                if(number % 2 == 0)
                {
                    evens.Add(number);
                }
            }
            if(evens.Count == 0) { return 0; }
            var avgof = Queryable.Average(evens.AsQueryable());
            return avgof;
        }

        public int Factorial(int number)
        {
            var factor = 1;
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = number; i>0; i--)
            {
                factor *= i;
            }
            return factor;
        }
    }
}
