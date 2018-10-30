using System;

namespace Bonus_3
{
    class HighLow : Guesser
    {
        public int min = 0;
        public int max = 100;

        public override int Guess()
        {
            guessCount++;
            return guessCount;
        }

        public int BinarySearchRecursive(int key)
        {
            int min, max;
            

            if (min > max)
            {

                Console.WriteLine("min was greater than max.");
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == mid)
                    return ++mid;
                else if (key < mid)
                    return BinarySearchRecursive(key);
                else
                    return BinarySearchRecursive( key);

            }
        }

    }
}