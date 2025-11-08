using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game
{
    internal abstract class Cell
    {
        protected int index;
        protected Cell(int index)
        {
            this.index = index;
        }

        protected abstract int GetIndex();
    }
}
