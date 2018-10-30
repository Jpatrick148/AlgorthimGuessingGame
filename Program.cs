using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool foundNum = false;
            
            GuessingGameApp ga = new GuessingGameApp();
            BruteForce brute = new BruteForce();
            Randy rando = new Randy();

            Console.WriteLine();
            while (foundNum == false)
            {

                
                //int guess = brute.Guess();
                //foundNum = ga.GuessAnswer(guess);

                //rando.Guess();
                //int guess = rando.GuessRand();
                //foundNum = ga.GuessAnswer(guess);
            }

            //rando.PrintGuesses();

            //brute.PrintGuesses();


            Console.ReadLine();
                
        }
    }
}
