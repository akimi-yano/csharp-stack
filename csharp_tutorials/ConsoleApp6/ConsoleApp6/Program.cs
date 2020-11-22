using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);


            // CHALLENGE: 
            // Try to write the code to generate the first 20 numbers in the sequence. 
            // (As a hint, the 20th Fibonacci number is 6765.)
            int prevprev = 0;
            int prev = 1;
            for (int _ = 2; _ <= 20; _++)
            {
                var temp =  prev;
                prev = prevprev + prev;
                prevprev = temp;
            }
            Console.WriteLine($"20th Fibonacci number is: {prev}");


            // Another solution
            var fiboNumbers = new List<int> { 1, 1 };

            while (fiboNumbers.Count < 20)
            {
                var pre1 = fiboNumbers[fiboNumbers.Count - 1];
                var pre2 = fiboNumbers[fiboNumbers.Count - 2];
                fiboNumbers.Add(pre1 + pre2);
            }

            foreach (var item in fiboNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
