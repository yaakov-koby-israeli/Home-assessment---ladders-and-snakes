using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladders_and_snakes_game.Configuration;

namespace Ladders_and_snakes_game.Players
{
    internal class Player : IPlayer
    {
        private static int _initID = 1;

        public int Id { get; private set; }

        // All players start at position 0
        public int Position { get; set; } = 0;

        public bool HasWon { get; set; } = false;

        public Player()
        {
            Id = _initID++;
        }

        public void MovePlayer(int diceResult)
        {
            int maxPosition = GameSettings.Rows * GameSettings.Cols;  // in our case 10x10 = 100
            int newPosition = Position + diceResult;

            // If above max → clamp to max
            if (newPosition > maxPosition)
            {
                Position = maxPosition;
            }
            else
            {
                
                Position = newPosition;
            }
        }
    }
}
