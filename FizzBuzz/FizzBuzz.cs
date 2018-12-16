using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        /// <summary>
        /// check if given number is fizz - a number divisible by 3
        /// </summary>
        /// <param name="number">tested number</param>
        /// <returns>bool value</returns>
        public bool isFizz (int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if given number is buzz - a number divisible by 5
        /// </summary>
        /// <param name="number">tested number</param>
        /// <returns>bool value</returns>
        public bool isBuzz (int number)
        {
            if (number % 5 == 0 && number % 3 != 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if given number is fizzbuzz - a number divisible by 5 and 3
        /// </summary>
        /// <param name="number">tested number</param>
        /// <returns>bool value</returns>
        public bool isFizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if given number is fizz, buzz or fizbuzz- a number
        /// divisible by 3, 5 or 3 and 5
        /// </summary>
        /// <param name="number">tested number</param>
        /// <returns>string value </returns>
        public string checkNumber(int number)
        {
            if (number % 5 ==0 && number % 3 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 ==0)
            {
                return "fizz";
            }
            else if ( number % 5 ==0)
            {
                return "buzz";
            }
                return "" + number;
        }

        /// <summary>
        /// calculete fizbuzz up to n
        /// </summary>
        /// <param name="howMany">number method will calculate up to</param>
        /// <returns>list of strings where each string can be number fizz,
        /// buzz or fizzbuzz</returns>
        public List<string> CalculateForNNumbers(int howMany)
        {
            List<string> tab = new List<string>(howMany);
            for (int n = 1; n <= howMany; n++)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    tab.Add( "fizzbuzz");
                }
                else if (n % 3 == 0)
                {
                    tab.Add("fizz");
                }
                else if (n % 5 == 0)
                {
                    tab.Add("buzz");
                }
                else
                {
                    tab.Add(""+n);
                }
            }
            return tab;
        }
    }
}
