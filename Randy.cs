using System;

namespace Bonus_3
{
    class Randy : Guesser
    {
        public Random x = new Random();

        public override int Guess()
        {
            guessCount++;
            //GuessRand();
            return guessCount;
        }
        
         public int GuessRand()
         {
            
            int rndNum = x.Next(1, 101);
            return rndNum;
       }         

    }
}