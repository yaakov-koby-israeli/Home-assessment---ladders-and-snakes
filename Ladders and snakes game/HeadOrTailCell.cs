using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladders_and_snakes_game
{
    internal class HeadOrTailCell: Cell
    {
        private enumCellType _cellType;
        public HeadOrTailCell(int index , enumCellType cellType) : base(index) 
        {
            this._cellType = cellType;
        }
        protected override int GetIndex()
        {
            return _index;
        }

        public enumCellType GetCellType()
        {
            return _cellType;
        }
    }
}
