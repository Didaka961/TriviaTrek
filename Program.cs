using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Mоля въведете число от 2 до 4.");
            int playerAmount = int.Parse(Console.ReadLine());
            PlayersSet set1 = new PlayersSet(playerAmount);
            set1.Setup();
        }
    }
}
