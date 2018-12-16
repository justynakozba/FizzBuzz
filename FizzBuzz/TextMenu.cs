using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class TextMenu
    {
        private void printMenu()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Text menu FizzBuzz game");
            Console.WriteLine("==============================================");
            Console.WriteLine(" Select number");
            Console.WriteLine(" 0  -Show menu");
            Console.WriteLine(" 1  -Calculate FizzBuzz for n numbers");
            Console.WriteLine(" 2  -Check if number is Fizz");
            Console.WriteLine(" 3  -Check if number is Buzz");
            Console.WriteLine(" 4  -Check if number is FizzBuzz");
            Console.WriteLine(" 5  -Calculete FizzBuzz for given number");
            Console.WriteLine("==============================================");
        }

        public void textMenu()
        {
            FizzBuzz fb = new FizzBuzz();
            while (true)
            {
               printMenu();
                string menuSelection = Console.ReadLine();
                switch (menuSelection)
                {
                    case "0":
                        printMenu();
                        break;
                    case "1":
                        {
                            int number = 0;
                            Console.WriteLine("Give n numbers:");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong number!");
                                printMenu();
                                return;
                            }
                            List<string> result= fb.CalculateForNNumbers(number);
                            foreach (string s in result)
                            {
                                Console.WriteLine(" " + s);
                            }
                            break;
                        }
                    case "2":
                        {
                            int number = 0;
                            Console.WriteLine("Give number:");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong number!");
                                printMenu();
                                return;
                            }
                            if (fb.isFizz(number))
                            {
                                Console.WriteLine("The " + number + " is Fizz");
                            }
                            else
                            {
                                Console.WriteLine("The " + number + " is not Fizz");
                            }
                            break;
                        }
                    case "3":
                        {
                            int number = 0;
                            Console.WriteLine("Give number:");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong number!");
                                printMenu();
                                return;
                            }
                            if (fb.isBuzz(number))
                            {
                                Console.WriteLine("The " + number + " is Buzz");
                            }
                            else
                            {
                                Console.WriteLine("The " + number + " is not Buzz");
                            }
                            break;
                        }
                    case "4":
                        {
                            int number = 0;
                            Console.WriteLine("Give number:");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong number!");
                                printMenu();
                                return;
                            }
                            if (fb.isFizzBuzz(number))
                            {
                                Console.WriteLine("The " + number + " is FizzBuzz");
                            }
                            else
                            {
                                Console.WriteLine("The " + number + " is not FizzBuzz");
                            }
                            break;
                        }
                    case "5":
                        {
                            int number = 0;
                            Console.WriteLine("Give number:");
                            try
                            {
                                number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong number!");
                                printMenu();
                                return;
                            }

                            Console.WriteLine("The given number is: " + fb.checkNumber(number));
                            break;
                        }
                }

            }
        }
    }
}
