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

            for (int frame = 1; frame <= 10; frame++)
            {
                foreach (var player in listOfPlayers)
                {
                    Console.WriteLine("How many pins are down?");
                    int fallenPins = Convert.ToInt32(Console.ReadLine());

                    player.Roll(fallenPins);

                    if (fallenPins != 10)
                    {
                        Console.WriteLine("How many pins are down?");
                        fallenPins = Convert.ToInt32(Console.ReadLine());

                        player.Roll(fallenPins);
                    }
                }
            }
        }
    }
}
