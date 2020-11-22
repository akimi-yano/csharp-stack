//it is useful to import this
using System;

//to group and organize classes when there are multiple classes 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        // main method - every program in C# needs it
        // which is like an entry point; this is where the 
        // program starts - it has to be named as main 
        // main method also needs to be static - which means it 
        // is not going to change dinamically as program is executing
        // void as this method does not return anything
        // sting[] arg - string array of arguement
        // every program may have an argument input
        // take this arguement and do something with it
        // can have multiple arguements 
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");

            }





        }
    }
}
