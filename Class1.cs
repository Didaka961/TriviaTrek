﻿using System;
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
        public PlayersSet()
        {
            Console.WriteLine("Mоля въведете число от 2 до 4.");
            int playerAmount = int.Parse(Console.ReadLine());

            while (true)
            {
                if (playerAmount > 1 && playerAmount < 5)
                {
                    players = new int[playerAmount];
                    for (int i = 1; i < playerAmount; i++)
                    {
                        players[i]++;
                    }
                    playerLocation = new int[playerAmount];
                    break;
                }
                else if (playerAmount < 2)
                {
                    Console.WriteLine("Твърде малко играчи моля въведете число от 2 до 4.");
                    playerAmount = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Твърде много играчи моля въведете число от 2 до 4.");
                    playerAmount = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}
