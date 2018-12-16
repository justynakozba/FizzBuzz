using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
           List<String> result = fb.Calculate(20);
            //Console.WriteLine("moja tablica: " + result[15]);
            /*
             TODO:
             Create text menu allowing folowing
                -> Calculate FizzBuzz for n numbers
                -> Check if number is fizz
                -> Check if number is buzz
                -> Check if number is fizzbuzz
                -> Calculete Fizzbuzz for given number
            Add unit test for first 100 numbers
                */
            for (int i =0; i< 20; i++)
            {
                Console.WriteLine(" " + result[i]);
            }
            Console.ReadLine();

        }
    }
}
