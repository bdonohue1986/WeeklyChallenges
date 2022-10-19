using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Count() == 0) { return false};
            var lookingFor = false;
            bool exist = Array.Exists(vals, element => element == lookingFor);
            if (exist)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null )
            {
                return false;
            }
            int answer = 0;
            foreach (int i in numbers)
            {
                if ( i % 2 != 0) 
                {
                    answer += i;
                }
            }
            if(answer %2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0) { return 0; }
           return dividend / divisor;
          
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public string ChangeAllElementsToUppercase(string[] words)
        {
            foreach (string word in words)
            {
                word.ToUpper();
            }
                
        }
    }
}
