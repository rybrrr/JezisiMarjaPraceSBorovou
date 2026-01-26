using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraosPokus2.Model
{
    internal class Field
    {
        public bool isMine { get; }
        public int NeighboringMines { get; }

        public Field(bool isMine, int neighboringMines)
        {
            this.isMine = isMine;
            NeighboringMines = neighboringMines;
        }
    }
}
