using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLogic
{
    public class Game
    {
        public List<Player> listOfPlayers = new();

        public void Run(int numberOfPlayers)
        {
            for (int index = 0; index < numberOfPlayers; index++)
            {
                listOfPlayers.Add(new Player());
            }
        }
    }
}
