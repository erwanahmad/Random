using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(StaticRandom.Next());
            }
        }

        private class StaticRandom
        {
            internal static bool Next()
            {
                throw new NotImplementedException();
            }
        }
    }
}
