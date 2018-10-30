using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class BruteForce : Guesser
    {
        protected int guessCount = 100;

        public override int Guess()
        {
            guessCount++;
            return guessCount;
        }

        

    }
}
