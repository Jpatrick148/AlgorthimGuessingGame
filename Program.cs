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

            Console.WriteLine();
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
            rando.PrintGuesses();
            Console.WriteLine("Press enter to run High Low.");

            shoot.BinarySearch(direction);

            do
            {
                shoot.Guess();
                int guess = shoot.BinarySearch(direction);
                Console.WriteLine(guess);
                Console.ReadLine();
                direction = ga.GuessAnswerInt(guess);
            } while (direction != 0);

            shoot.PrintGuesses();
            
            Console.ReadLine();
                
        }
    }
}
