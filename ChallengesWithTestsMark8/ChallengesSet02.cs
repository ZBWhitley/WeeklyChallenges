using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {           
            if (char.IsLetter(c)) 
            {
                return true;
            }
            else
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {   
            if (vals == null || vals.Length == 0)
                { return true; }
            else if (vals.Length % 2 == 0)
                { return true; }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {   
            if (numbers == null || numbers.Any() == false)
                return 0;
            else
            {
                var max = numbers.Max();
                var min = numbers.Min();
                var sum = max + min;
                return sum;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length <= str2.Length) 
            {
                return str1.Length;
            }
            else return str2.Length;
        } 

        public int Sum(int[] numbers)
        {   
            if (numbers == null) { return 0; }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {   
            if (numbers == null) { return 0;}
            var evens = new List<int>();
            foreach (var number in numbers) 
            {
                if (number % 2 == 0) 
                {
                    evens.Add(number);                    
                }           
            }return evens.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            if (numbers.Sum() %2 == 0) { return false; }
            else return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {


            if (number < 0)
            {
                return number = 0;
            }


            else
            {
                var range = Enumerable.Range(0, (int)number);
                var answer = new List<int>();

                foreach (var num in range)
                {
                    if (num % 2 != 0)
                    {
                        answer.Add(num);
                    }
                }
                return answer.Count;
            }
        }
    }
}
