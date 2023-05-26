using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Intro();
         int Guess();
         void Win(int attempts);
         void Low();
         void High();
         void End();
    }
}