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
            FindPiThread fp = new FindPiThread(1000);
        }
    }
}
