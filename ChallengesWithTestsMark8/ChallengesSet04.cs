using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            var evens = numbers.Where(x => (x % 2 ) == 0).Sum();
            var odds = numbers.Where(x => (x % 2) != 0).Sum();
            return answer = (evens - odds);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strArray = { str1, str2, str3, str4 };
            var answer = strArray.Min(y=>y.Length);
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int [] nArr = { number1, number2, number3, number4 };
            var answer = nArr.Min();
            return answer;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            return;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if 
               (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1  )
            {return true;}
            else {return false;}
        }

        public bool IsStringANumber(string input)
        {
            double number;
            bool test = double.TryParse(input, out number);
            if (test) {return true;}
            return false;            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var isNull = objs.Where(o => o == null).Count();
            var isNotNull = objs.Where(o=> o != null).Count();
            if (isNull > isNotNull) { return true; }
            else return false;            
        }

        public double AverageEvens(int[] numbers)
        {   if (numbers == null || numbers.Length == 0) return 0;
            if (numbers.Where(n => (n % 2 == 0)).Count()==0) return 0;
            var answer = numbers.Where(n=>(n%2==0)).Average(); return answer;            
        }

        public int Factorial(int number)
        {   if (number == 0) return 1;
            IEnumerable<int> numbers = Enumerable.Range(1, number);
            var answer = numbers.Aggregate((a, b) => a * b);
            return answer;
        }
    }
}
