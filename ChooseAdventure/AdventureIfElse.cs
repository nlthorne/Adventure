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

        //This is considered?
        public Adventure()
        {
            this.player = new Player();
        }
        public void RunAdventure()
        {
            Console.WriteLine("Welcome to your adventure {0}!", player.name);
            Console.WriteLine("{0}, you find yourself in a dark room. You see a small light in the far distance, and something in your pocket?  Choose: light or pocket", player.name);
            string decision = Console.ReadLine();
            if (decision == "light")
            {
                Console.WriteLine("You walk towards the light, unaware of what is possibly awaiting you..");
                DecisionLight();
            }
            else if (decision == "pocket")
            {
                Console.WriteLine("You rummage through your pocket, hoping to find something that will help you with the situation..");
                DecisionPocket();
            }
            else
            {
                Console.WriteLine("That is not a valid option, you have chosen..poorly..");
            }

        }
        
        private void DecisionPocket()
        {

            Console.WriteLine("You fumble in your pocket briefly and find a match.  You strike it on the ground and see a door out next to you, good job!");
        }
        private void DecisionLight()
        {
            Console.WriteLine("You walk blindly into the dark feeling for anything resembling a wall.  You're so focused on feeling with your hands you realize to late the floor is gone..");
        }
        
    }
}

