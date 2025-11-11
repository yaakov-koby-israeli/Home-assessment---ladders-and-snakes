using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game.Front
{
    internal class UserInputValidation
    {
        public static bool  SnakesInputValidation(string snakesNumber)
        {
            bool isValid = true;

            if (!int.TryParse(snakesNumber, out int snakes))
            {
                isValid = false;
            }
            if (snakes < 1 || snakes > Configuration.GameSettings.MaxSnakes)
            {
                Console.WriteLine($"❌ Invalid number of snakes. Enter a number between 1 and {Configuration.GameSettings.MaxSnakes}.\n");
                isValid = false;
            }

            return isValid;
        }
    }
}
