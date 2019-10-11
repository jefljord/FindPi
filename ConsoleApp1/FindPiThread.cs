using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FindPiThread
    {
        public int numOfDarts;
        public int hitCounter;
        Random x;

        public FindPiThread(int darts)
        {
            numOfDarts = darts;
            hitCounter = 0;
            x = new Random();
            double hit = x.NextDouble();
            Console.WriteLine(hit);
            Console.ReadKey();
        }
    }
}
