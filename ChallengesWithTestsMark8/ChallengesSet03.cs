using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {            
            for (int i = 0; i < vals.Length; i++) 
            {
                if (vals[i] == false) return true;                
            }
                return false;
            
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null || numbers.Count() == 0) 
            {
                return false;
            }
            var sum = numbers.Sum();
            if (sum % 2 != 0) 
            {
                return true;
            }
            else { return false; }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            for (int i = 0; i < password.Length; i++) 
            {
                if (Char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (Char.IsLower(password[i])) 
                {
                     isLower = true;
                }
                if (Char.IsNumber(password[i])) 
                {
                    isNumber = true;
                }                

            }
                if (isUpper && isLower && isNumber == true) 
                {
                    return true;
                }
                else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val[0];
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {   
            if (dividend == 0 || divisor == 0) { return 0; }
            var answer = dividend / divisor;
                return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            var answer = nums[nums.Length - 1] - nums[0];
            return answer;
        }

        public int[] GetOddsBelow100()
        {            
            List <int> store = new List <int>();
            int[] arr = Enumerable.Range(1, 100).ToArray();
            for (int i = 0; i < arr.Length; i++) 
            {
                if ( i % 2 == 0) 
                {
                    store.Add(arr[i]);
                }
            }
                int[] answer = store.ToArray();
                return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();                
            }
        }
    }
}
