using System;

namespace Bonus_3
{
    class HighLow : Guesser
    {
        protected int min = 1;
        protected int max = 100;
        int lastGuess;
        Random x = new Random();

        public override int Guess()
        {
            guessCount++;
            return guessCount;
        }

        public int BinarySearch(int direction)
        {
            if (direction == 2)
            {
                lastGuess = x.Next(min, max + 1);
                return lastGuess;
            }


            else if (direction == 1)
            {
                max = lastGuess - 1;
                lastGuess = x.Next(min, max + 1);
            }
            else if (direction == -1)
            {
                min = lastGuess + 1;
                lastGuess = x.Next(min, max + 1);
                return lastGuess;
            }

            return -1;
        }

    }
}