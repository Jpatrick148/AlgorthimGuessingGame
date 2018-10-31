using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class GuessingGameApp
    {
        public Random r = new Random();
        private int num;
        
        
        

        public GuessingGameApp()
        {
           
            num = r.Next(1, 101);
            Console.WriteLine(num);
        }

        public GuessingGameApp(int num)
        {
            this.num = num;
        }

        public int GuessAnswerInt(int input)
        {
            if (input == num)
            {
                return 0;
            }
            else if (input > num)
            {
                return 1;
            }
            else if (input < num)
            {
                return -1;
            }

            return -2;
        }

        public bool GuessAnswer(int input)
        {
            
            int diff = 0;
            if (input == num)
            {
                //Console.WriteLine("Match! You win!");
                return true;
            }
            else if (input > num)
            {
                diff = input - num;
                if (diff > 10)
                {
                    //Console.WriteLine("Way too high");
                }
                else
                {
                   // Console.WriteLine("Too high!");
                }
            }
            else
            {
                diff = num - input;
                if (diff > 10)
                {
                    //Console.WriteLine("Way too low!");
                }
                else
                {
                    //Console.WriteLine("Too low");
                }
            }

            return false;
        }

      


    }
}
