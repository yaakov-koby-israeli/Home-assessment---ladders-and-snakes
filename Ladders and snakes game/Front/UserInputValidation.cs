using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game.Front
{
    internal sealed class UserInputValidation
    {
        public static bool InputValidation(string userInput , int maxValue)
        {
            bool isValid = true;

            if (!int.TryParse(userInput, out int userInputAsNumber))
            {
                isValid = false;
            }

            if (userInputAsNumber < 1 || userInputAsNumber > maxValue)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
