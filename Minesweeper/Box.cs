using System;

namespace Minesweeper
{
  

    internal class Box
    {
        private bool mine;
        private int value;
        private bool sweeped;
        public Box()
        {
            mine = false;
            value = 0;
            sweeped = false;
        }

        internal void addMine()
        {
            mine = true;
        }

        public override string ToString()
        {
            if (!sweeped) return "X";
            else if (mine) return "M";
            else if (value == 0) return " ";
            else return "" + value;

        }

        internal void SumOne()
        {
            this.value++;
        }

        internal void Sweep()
        {
            this.sweeped = true;
        }
    }
}