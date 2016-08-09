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
            adventure.player.getPlayerName();
            adventure.RunAdventure();

            Console.WriteLine("Thank you for playing!!");
            Console.ReadLine();

        }

    }
}
