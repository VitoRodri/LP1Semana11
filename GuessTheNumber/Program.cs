using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();
            Controller controller= new Controller(model);
            IView view= new View(controller,model);

            controller.Run(view);
        }
    }
}