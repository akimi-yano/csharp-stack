using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> actors = new List<string>();

            actors.Add("Tom Cruise");
            actors.Add("Madonna");
            actors.Add("Bruce Lee");
            actors.Add("Jimmy Fallon");

            Console.WriteLine("Linear search results: \n\nIn the collection, there are {0} actors:", actors.Count);
            PrintOut(actors);

            Console.WriteLine("\nOf which, the IndexOf(\"Madonna\") is {0}", actors.IndexOf("Madonna"));

        }

        private static void PrintOut(List<string> cs)
        {
            Console.WriteLine();
            foreach (string item in cs)
            {
                Console.WriteLine(item);
            }
        }

    }
}
