using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View: IView
    {
        private readonly Model model;
        private readonly Controller Controller;
        
        public View(Controller controller, Model model)
        {
            this.model=model;
            this.Controller=controller;

        }
        public void Intro()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            
            
        }
        public int Guess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Win(int attempts)
        {
            Console.WriteLine(
                    "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }
        public void Low()
        {
            Console.WriteLine("Too low! Try again.");
        }
        public void High()
        {
            Console.WriteLine("Too high! Try again.");
        }
        public void End()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
        
    }
}