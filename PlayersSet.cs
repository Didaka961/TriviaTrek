using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TriviaTrek
{
    class PlayersSet
    {
        public int[] playerLocation;
        public string[] players;
        public int spaces = 51;
        public int currentPlayer = 0;

        static StreamReader sr = new StreamReader("C:\\Users\\User\\source\\repos\\TriviaTrek\\Questions.txt");
        string[] question = sr.ReadLine().Split(',').Reverse().ToArray();
        
        public PlayersSet()
        {
        }
        public void Setup() 
        {
            Console.WriteLine("Mоля въведете число от 2 до 4.");
            int playerAmount = int.Parse(Console.ReadLine());
            while (true)
            {
                if (playerAmount > 1 && playerAmount < 5)
                {
                    players = new string[playerAmount];
                    for (int i = 0; i < playerAmount; i++)
                    {
                        Console.WriteLine($"Моля въведете име на играч номер {i+1}");
                        players[i] = Console.ReadLine();
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
        public void Move()
        {
            List<string> questions = new List<string> { question[2] };
            Console.WriteLine(questions[0]);
            Random random = new Random();
            int roll = random.Next(1,6);
            Console.WriteLine($"Падна ти се {roll}");
            playerLocation[currentPlayer] += roll;
            for (int i = 0; i < playerLocation.Length; i++)
            {
                Console.Write(playerLocation[i] + " ");
                for (int j = 0; j < playerLocation[i]; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(" " + players[i]);
                
            }
            
            if (roll == 1 || roll == 2)
            {
                
                
            }
        }
        public void showPlayer()
        {
            Console.WriteLine(players[currentPlayer]);
        }
    }
}
