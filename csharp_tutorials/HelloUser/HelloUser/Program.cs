using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting();
            WaitForKey();
        }


        /// <summary>
        /// Get the user's first name
        /// </summary>
        /// <returns>The name</returns>
        private static string GetFirstName()
        {
            Console.Write("Please enter your first name: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Get the user's last name
        /// </summary>
        /// <returns>The name</returns>
        private static string GetLastName()
        {
            Console.Write("Please enter your last name: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Prints a greeting to the user
        /// </summary>
        private static void PrintGreeting()
        {
            var first = GetFirstName();
            var last = GetLastName();

            var now = DateTime.Now;

            Console.WriteLine("Hello, " + first + " " + last + "!");
            Console.WriteLine("The Date is " + now.ToShortDateString());
            Console.WriteLine("The Time is " + now.ToShortTimeString());
        }

        /// <summary>
        /// Waits for a key to be pressed
        /// </summary>
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
