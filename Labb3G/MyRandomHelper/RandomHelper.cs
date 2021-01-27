namespace Labb3G.MyRandomHelper
{
    using System;

    public static class RandomHelper
    {
        private static Random random = new Random();

        //Creats a random number
        public static int RandomNumber(int Minimal, int Maximal)
        {
            return random.Next(Minimal, Maximal);
        }
    }
}
