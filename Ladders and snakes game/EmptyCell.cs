using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game
{
    internal class EmptyCell: Cell
    {
        public EmptyCell(int index): base(index) { }

        protected override int GetIndex()
        {
            return index;
        }
    }
}
