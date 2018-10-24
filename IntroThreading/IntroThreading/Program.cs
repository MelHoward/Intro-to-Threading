using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter number of darts to throw: ");
            int toThrow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number threads: ");
            int numThreads = Convert.ToInt32(Console.ReadLine());

            FindPiThread fp = new FindPiThread(toThrow);
            int inCircle = fp.BoardCount;
            Console.Write(inCircle);
            
        }

        
    }
}
