using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                 if(vals[i] == false) { return true; }
             
            }
            return false;
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
            var upper = false;
            var lower = false;
            var number = false;
            bool answer = false;

            for(int i = 0; i < password.Length; i++)
            {
                
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    number = true;
                }
                if(number == true && upper == true && lower == true) { answer = true; }


            }
            return answer;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0) { return 0; }
           return dividend / divisor;
          
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums.First();
            var last = nums.Last();
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for(int i = 1; i<100; i += 2) { odds.Add(i); }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           
           for (int i = 0; i < words.Length; i++) 
            { 
               words[i]= words[i].ToUpper(); 
            }

            

        }
    }
}
