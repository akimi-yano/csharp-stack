using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoQueue();
        }


        private static void DemoQueue()
        {
            Queue<string> movies = new Queue<string>();
            movies.Enqueue("Ace Ventura");
            movies.Enqueue("Batman");
            movies.Enqueue("Cable Guy");
            movies.Enqueue("Dallas Buyers Club");
            movies.Enqueue("East of Eden");

            Console.WriteLine("Default content of Queue");

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nDequeuing '{0}'", movies.Dequeue());
            Console.WriteLine("The next item to dequeue using peek: {0}",
                movies.Peek());
            Console.WriteLine("Dequeuing '{0}'", movies.Dequeue());

            Queue<string> queueCopy = new Queue<string>(movies.ToArray());
            Console.WriteLine("\nContents of the first copy:");
            foreach (string movie in queueCopy)
            {
                Console.WriteLine(movie);
            }

            string[] array2 = new string[movies.Count * 2];
            movies.CopyTo(array2, movies.Count);

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and null");

            foreach (string movie in queueCopy2)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"Dallas Buyers Club\") = {0}",
                queueCopy.Contains("Dallas Buyers Club"));
            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);



        }
    }
}
