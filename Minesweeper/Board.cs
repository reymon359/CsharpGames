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
                for(int j = 0; j < this.cols + 2; j++)
                    boxes[i, j] = new Box();

            Random rnd = new Random();
            // /*Fill the board with bombs*/
            for (int i = 1; i < this.rows + 1; i++)
                for (int j = 1; j < this.cols + 1; j++)
                    if (rnd.Next(10) < 4)
                    {
                        this.boxes[i, j].addMine();
                        // sum 1
                        this.SumOnes(i, j);
                    }
            }

        internal void SweepBox(int row, int col)
        {
            throw new NotImplementedException();
        }

        private void SumOnes(int i, int j)
        {
            for (int f = i - 1; f <= i + 1; f++)
                for (int c = i - 1; c <= i + 1; c++)
                    this.boxes[f, c].SumOne();
        }

        internal void Render() {
            for (int i = 1; i < this.rows + 1; i++)
            {
                for (int j = 1; j < this.cols + 1; j++)
                {
                    Console.Write(" | " + this.boxes[i, j]);

                }
                Console.WriteLine(" | ");

            }

        }

        
               
    }
}