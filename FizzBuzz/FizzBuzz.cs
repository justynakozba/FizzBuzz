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
            result = new List<String>(100);
        }
        private List<String> result;

        public bool isFizz (int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                return true;
            }
            return false;
        }

        public bool isBuzz (int number)
        {
            if (number % 5 == 0 && number % 3 != 0)
            {
                return true;
            }
            return false;
        }

        public bool isFizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return true;
            }
            return false;
        }


        public List<string> Calculate(int i)
        {
            List<string> tab = new List<string>(i);
            for (int n = 1; n <= i; n++)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                   // Console.Write(" fizzbuzz ");
                    tab.Add( "fizzbuzz");
                }
                else if (n % 3 == 0)
                {
                    //Console.Write(" fizz ");
                    tab.Add("fizz");
                }
                else if (n % 5 == 0)
                {
                    // Console.Write(" buzz ");
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
