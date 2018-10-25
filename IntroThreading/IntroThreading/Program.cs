using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IntroThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            double dartsInCircle = 0;
            List<Thread> threads = new List<Thread>();
            List<FindPiThread> findPiThreads = new List<FindPiThread>();

            Console.Write("Please enter number of darts to throw: ");
            int toThrow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number threads: ");
            int numThreads = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numThreads; i++)
            {
                FindPiThread fp = new FindPiThread(toThrow);
                findPiThreads.Add(fp);
                Thread thread = new Thread(new ThreadStart(fp.ThrowDarts));
                threads.Add(thread);
                thread.Start();
                Thread.Sleep(16);
            }

            for(int i = 0; i < numThreads; i++)
            {
                threads[i].Join();
            }

            for(int i = 0; i < numThreads; i++)
            {
                dartsInCircle += findPiThreads[i].BoardCount;
            }

            double myPi = (4 * (dartsInCircle / (numThreads * toThrow)));
            Console.Write("Ratio Calculated : ");
            Console.Write(myPi);
            Console.ReadKey();
            
        }

        
    }
}
