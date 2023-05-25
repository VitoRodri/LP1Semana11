using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private readonly Model model;
        private View view;
        private int guess;
        private int attempts;
        private bool guessedCorrectly= false;
        public Controller(Model model)
        {
            this.model=model;
            attempts=0;

        }

        public void Run(View view)
        {
            this.view=view;
            view.Intro();

            do
            {
                guess=view.Guess();
                
                attempts++;

                switch(model.VerifyGuess(guess))
                {
                    case 0:
                    view.Win(attempts);
                    guessedCorrectly=true;
                    break;

                    case 1:
                    view.Low();
                    break;

                    default:
                    view.High();
                    break;
                }
            }
            while(!guessedCorrectly);
            view.End();

        }
    }
}