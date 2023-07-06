using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrek
{
    class PlayersSet
    {
        public int[] playerLocation;
        int[] players;
        int spaces = 51;
        int currentPlayer = 0;
        public int PlayerAmount;

        public PlayersSet(int PlayerAmount) 
        { 
            this.PlayerAmount = PlayerAmount;
        }
        public void Setup() 
        { 
            while (true)
            {
                if (PlayerAmount > 1 && PlayerAmount < 5)
                {
                    players = new int[PlayerAmount];
                    for (int i = 1; i < PlayerAmount; i++)
                    {
                        players[i]++;
                    }
                    playerLocation = new int[PlayerAmount];
                    break;
                }
                else if (PlayerAmount < 2)
                {
                    Console.WriteLine("Твърде малко играчи моля въведете число от 2 до 4.");
                    PlayerAmount = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Твърде много играчи моля въведете число от 2 до 4.");
                    PlayerAmount = int.Parse(Console.ReadLine());
                }
           
            }
            
        }
        

    }
}
