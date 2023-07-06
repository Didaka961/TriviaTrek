using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TriviaTrek
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("===Здравей моля избери една от опциите:===\n1) Започни нова игра\n2) Изход");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlayersSet game = new PlayersSet();
                        game.Setup();
                        while (true)
                        {
                            Console.WriteLine("===Моля избери една от опциите:=== \n 1) Хвърли зарчето \n 2) Виж кой е на ред \n 3) Започни нова игра \n 4) Изход");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    game.Move(); break;
                                case 2:
                                    game.showPlayer(); break;
                                case 3:
                                    string file = Assembly.GetExecutingAssembly().Location;
                                    System.Diagnostics.Process.Start(file); break;
                                case 4: Environment.Exit(1); break;
                            }
                        }

                    case 2: Environment.Exit(1); break;
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
