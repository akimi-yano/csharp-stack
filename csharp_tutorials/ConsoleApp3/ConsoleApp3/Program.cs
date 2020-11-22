using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1: ");
            // normal while loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }


            Console.WriteLine("Test 2: ");
            // if we flip the order of while loop condition and logic,
            // always at least do the first loop
            int counter2 = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);


            Console.WriteLine("Test 3: ");
            // for loop
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            // CHALLENGE:
            // write C# code to find the sum of all integers 1 through 20 
            // that are divisible by 3
            int total = 0;
            for (int num = 1; num <= 20; num++)
            {
                if (num % 3 == 0) 
                {
                    total += num;
                }
                  
            }
            Console.WriteLine($"The sum is: {total}");
        }
    }
}
