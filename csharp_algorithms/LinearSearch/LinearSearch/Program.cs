using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 7;
            int[] array = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("Our array contsins:");
            Array.ForEach(array, x => Console.Write(x + " "));
            Console.WriteLine($"\n\nThe result of a linear search " +
                $"for {theValue} is: ");
            Console.WriteLine(linearSearch(array, theValue));
        }

        static int linearSearch(int[] a, int x)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                   return i;
                }
            }

            return -1;
        }
    }
}
