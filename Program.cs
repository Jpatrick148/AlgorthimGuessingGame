using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool foundNumB = false;
            bool foundNumR = false;
            int direction = 2;
            
            GuessingGameApp ga = new GuessingGameApp();
            BruteForce brute = new BruteForce();
            HighLow shoot = new HighLow();

            Console.WriteLine("Bruce goes first.");
            while (foundNumB == false)
            {
                brute.Guess();
                int guess = brute.BruceForce();
                foundNumB = ga.GuessAnswer(guess);
            }

            brute.PrintGuesses();
            Console.WriteLine("Press enter to run random");
            Console.ReadLine();
            Randy rando = new Randy();
            while (foundNumR == false)
            {
                rando.Guess();
                int guess = rando.GuessRand();
                foundNumR = ga.GuessAnswer(guess);
            }

            Console.WriteLine("Randy tried and ");
            rando.PrintGuesses();

            Console.WriteLine("Press enter to run High Low.");
            Console.ReadLine();
            shoot.BinarySearch(direction);

            do
            {
                shoot.Guess();
                int guess = shoot.BinarySearch(direction);
                direction = ga.GuessAnswerInt(guess);
            } while (direction != 0);

            Console.WriteLine("\n Shooter ");
            shoot.PrintGuesses();
            
            Console.ReadLine();
                
        }
    }
}
