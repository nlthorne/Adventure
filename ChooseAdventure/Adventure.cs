using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseAdventure
{
    class Adventure
    {
        public Player player;

        public Adventure()
        {
            this.player = new Player();
        }
        public void RunAdventure()
        {
            Console.WriteLine("Welcome to your adventure {0}!", player.name);
            Console.WriteLine();
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    LeftRoom room = new LeftRoom();
                    room.enterRoom();
                    break;
                case "2":
                    //go right
                    break;
            }
        }
        private void GoLeft()
        {
            Console.WriteLine("you went left");
        }
        
    }
}

