using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                var s = FizzBuzz.Say(i++);
                Console.WriteLine(s);
                Thread.Sleep(1000);
            }
        }
    }

    public class FizzBuzz
    {
        public static string Say(int i)
        {
            string result;
            if (i % 3 == 0 && i % 5 == 0) result = "Fizz Buzz";
            else if (i % 3 == 0) result = "Fizz";
            else if (i % 5 == 0) result = "Buzz";
            else result = i.ToString();

            return result;
        }
    }
}
