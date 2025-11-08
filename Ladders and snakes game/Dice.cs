using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game
{
    internal class Dice
    {
        private Random random = new Random();
        public int RollTheDice()
        {
            // real return value between 1 and 6 
            return random.Next(1, 7); 
        }
    }
}
