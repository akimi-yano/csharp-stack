using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contsins: ");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a binary search for {theValue} is: ");
            Console.WriteLine(binarySearch(array, theValue));
        }

        /// <summary>
        /// a = array
        /// x = what we are serching for
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>

        public static int binarySearch(int[] a, int x)
        {
            // step1 - initialize the variables
            int p = 0; // beginning of the range
            int r = a.Length - 1; // the end of the range aka last slot

            // step2 - we do something (search for our value)
            while(p<=r) // when true, we are still in the range
            {
                int q = (p + r) / 2; // find the midpoint
                if (x < a[q])
                {
                    r = q - 1; // set r to mid point. we narrowed to 1st half of the array in the case x is less the data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1; // the opposite occurs. we bring p to the right of the array
                }
                else 
                {
                    return q;
                }
            }
            // step 3 - indicate not found
            return -1;
        }
    }
}
