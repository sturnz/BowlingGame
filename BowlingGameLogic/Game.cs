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
                    Console.WriteLine($"\nPlayer Number {listOfPlayers.IndexOf(player) + 1}:");

                    bool    rolledAStrike   = false;
                    bool    rolledASpare    = false;
                    int     framePoints     = 0;
                    int     fallenPins      = GetFallenPins();

                    player.Roll(fallenPins);
                    framePoints += fallenPins;

                    if (fallenPins == 10)
                    {
                        rolledAStrike = true;
                    }

                    if (!rolledAStrike)
                    {
                        fallenPins = GetFallenPins();

                        player.Roll(fallenPins);
                        framePoints += fallenPins;

                        if (framePoints == 10)
                        {
                            rolledASpare = true;
                        }
                    }

                    if(frame == 10)
                    {
                        if (rolledAStrike)
                        {
                            Console.WriteLine("BONUS ROUND");

                            fallenPins = GetFallenPins();
                            player.Roll(fallenPins);
                            fallenPins = GetFallenPins();
                            player.Roll(fallenPins);
                        }
                        else if (rolledASpare)
                        {
                            Console.WriteLine("BONUS ROUND");
                            fallenPins = GetFallenPins();
                            player.Roll(fallenPins);
                        }
                    }
                   
                }
            }

        }

        int GetFallenPins()
        {
            Console.WriteLine("How many pins are down?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
