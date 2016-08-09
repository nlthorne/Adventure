using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseAdventure
{
    class Player
    {
        public string name;

        public void getPlayerName()
        {
            Console.WriteLine("Please enter a name for your adventurer: ");
            this.name = Console.ReadLine();
        }
    }
}