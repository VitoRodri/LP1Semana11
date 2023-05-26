using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Controller
    {
        private IView view;
        private IComparer<Player> compareByName;
        private IComparer<Player> compareByNameReverse;
        private List<Player> list;
        private PlayerOrder playerOrder;
        private string option;
        private int score;
        private string name;
        Player newPlayer;
        private int minscore;
        PlayerOrder PlayerOrder;


        public Controller(List<Player> list)
        {
            this.list=list;
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);
            playerOrder= PlayerOrder.ByScore;

        }
        public void Run(IView view)
        {
            this.view=view;
            
            do
            {
                option=view.ShowMenu();
                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        name=view.InsertPlayerName();
                        score=view.InsertPlayerScore();
                        newPlayer = new Player(name, score);
                        list.Add(newPlayer);
                        break;
                    case "2":
                        view.ListPlayers(list);
                        break;
                    case "3":
                        minscore=view.Minscore();
                        Score(minscore);
                        view.ListPlayers(list);
                        break;
                    case "4":
                        playerOrder=view.SortPlayerList();
                        SortPlayers(list,playerOrder);

                        break;
                    case "0":
                        view.Bye();
                        break;
                    default:
                        view.Error();
                        break;
                }

                view.Continue();

                

            } while (option != "0");

        }
        private IEnumerable<Player> Score(int minscore)
        {
            foreach (Player p in list)
            {
                            
                if (p.Score > minscore)
                {
                    yield return p;
                }
            }
        }
        private void SortPlayers(List<Player>playerList, PlayerOrder playerOrder)
        {
            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    playerList.Sort();
                    break;
                case PlayerOrder.ByName:
                    playerList.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    playerList.Sort(compareByNameReverse);
                    break;
                default:
                    view.Error();
                    break;
            }
        }
    }
}