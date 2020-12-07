using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinarySearch
{
 /// <summary>
 /// Here we search an entire sorted array.
 /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] dinners = { "Pasta", "Apple Pie", "Tuna Melt", "Mushroom Omelet", "Duck", "Eggplant" };
            Console.WriteLine();
            Console.WriteLine("\nContent of array:");
            Console.WriteLine("--------------------");
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nContent after Sort:");
            Console.WriteLine("----------------------");
            Array.Sort(dinners);

            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }


            Console.WriteLine("\nBinarySearch for 'Beet Salad:");
            int index = Array.BinarySearch(dinners, "Beet Salad");
            DisplayWhere(dinners, index);

            Console.WriteLine("\nBinarySearch for 'Tuna Melt:");
            index = Array.BinarySearch(dinners, "Tuna Melt");
            DisplayWhere(dinners, index);
        }

        private static void DisplayWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index;

                Console.Write("Not found. Sorts between: ");

                if (index == 0)
                {
                    Console.Write("beginning of array and ");
                }
                else
                {
                    Console.Write("{0} and ", array[index - 1]);
                }

                if (index == array.Length)
                {
                    Console.Write("end of array.");
                }
                else
                {
                    Console.Write("{0}.", array[index]);
                }


            }
            else
            {
                Console.WriteLine("Found at index {0}.", index);
            }
        }

    }
}
