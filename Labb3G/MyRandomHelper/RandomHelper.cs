using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.MyRandomHelper
{
    public static class RandomHelper
    {
        private static Random random = new Random();

        public static int RandomNumber(int Minimal, int Maximal)
        {
            return random.Next(Minimal, Maximal);
        }
    }
}
