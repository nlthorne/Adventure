using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure adventure = new Adventure();
            adventure.player.setPlayerName();
            adventure.RunAdventure();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadLine();

        }

    }
}
