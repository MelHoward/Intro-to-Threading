using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*FindPiThread - this is the class that you will create to hold thread state.  It will also house your thread function
 * An int holding the number of darts it needs to throw
 * An int holding the count of darts that lands inside your dartboard (quarter)
 * A Random - this will be used to generate your throws!
 * 
 * 
 */
namespace IntroThreading
{
    class FindPiThread
    {
        int numThrow;
        int boardCount;
        Random rnd;

        public FindPiThread(int nT)
        {
            numThrow = nT;
            boardCount = 0;
            rnd = new Random();
        }

        public void ThrowDarts()
        { 
            for (int i = 0; i < numThrow; i++)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
                if((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                {
                    boardCount += 1;
                }
            }
        }

        public int BoardCount
        {
            get
            {
                return boardCount;
            }
        }
    }
}
