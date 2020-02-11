using System;

namespace Minesweeper
{
    internal class Board
    {
        private int rows;
        private int cols;

        private Box[,] boxes;
        public Board(int v1, int v2)
        {
            this.rows = v1;
            this.cols = v2;

            // Extra row and col that will not sum
            boxes = new Box[rows + 2, cols + 2]; 

            // Create board
            for(int i = 0; i < this.rows + 2; i++)
            {
                for(int j = 0; j < this.cols + 2; i++)
                {
                    boxes[i, j] = new Box();
                }
            }

            // Fill the board with bombs
        }

        internal void Render()
        {
            throw new NotImplementedException();
        }
    }
}