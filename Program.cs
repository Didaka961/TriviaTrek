using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace TriviaTrek
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("===Здравей моля пишете само числото опцичта която сте си избрали:===\n1) Започни нова игра");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Game game = new Game();
                        game.Setup();
                        while (game.win != game.spaces)
                        {
                            Console.WriteLine($"==={game.players[game.currentPlayer]} избери една от опциите:=== \n 1) Хвърли зарчето \n 2) Започни нова игра \n 3) Изход");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    game.Move(); break;
                                case 2:
                                    string file = Assembly.GetExecutingAssembly().Location;
                                    System.Diagnostics.Process.Start(file); break;
                                case 3: Environment.Exit(0); break;
                            }
                        }
                        Console.WriteLine(game.players[game.currentPlayer] + " спечели! Благодарим ви, че играхте Trivia Trek!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Въведохте невалидна команда! Стартиране на нова инстанция.");
                string file = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(file);
            }

        }
    }
}