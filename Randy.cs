using System;

namespace Bonus_3
{
    class Randy : Guesser
    {
        

        public override int Guess()
        {
            guessCount++;
            //GuessRand();
            return guessCount;
        }
        public Random x = new Random();
        private int rndNum;

         public int GuessRand()
         {
            
            rndNum = x.Next(1, 101);
            return rndNum;
       }         

    }
}