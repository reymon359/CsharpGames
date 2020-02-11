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

            // value > 0 in border
            for (int i = 0; i < this.rows + 2; i++)
            {
                boxes[0, i].SumOne();
                boxes[cols + 1, i].SumOne();
                boxes[i, 0].SumOne();
                boxes[i, rows + 1].SumOne();
            }
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

            this.boxes[row, col].Sweep();

            if (this.boxes[row, col].IsEmpty())
            {
                for (int f = row - 1; f <= row + 1; f++)
                    for (int c = col - 1; c <= col + 1; c++)
                        // this.boxes[f, c].Sweep();
                        if (!this.boxes[f, c].IsSweeped())
                            this.SweepBox(f, c);
            }
            
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