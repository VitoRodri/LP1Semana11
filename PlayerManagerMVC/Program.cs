using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Program
    {
        
        private static void Main()
        {
            List<Player> playerlist= new List<Player>()
            {
                new Player("Best player ever", 100),
                new Player("An even better player", 500),
            };
            Controller controller=new Controller(playerlist);
            IView view= new View(controller);
            controller.Run(view);
            

        }
    }
}