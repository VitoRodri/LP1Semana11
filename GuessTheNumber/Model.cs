using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        private Random random = new Random();
        
        private int targetNumber;


        public  Model()
        {
            targetNumber = random.Next(1, 101);
             
        }
        public int VerifyGuess(int guess)
        {
            if (guess==targetNumber)
            {
                return 0;
            }
            else if (guess < targetNumber)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}