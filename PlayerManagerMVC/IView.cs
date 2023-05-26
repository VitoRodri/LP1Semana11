using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public interface IView
    {
        string ShowMenu();
        void Continue();
        string InsertPlayerName();
        int InsertPlayerScore();
        void ListPlayers(IEnumerable<Player> playersToList);
        int Minscore();
        PlayerOrder SortPlayerList();
        void Error();
        void Bye();
    }
}