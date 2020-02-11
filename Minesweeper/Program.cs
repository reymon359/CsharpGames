using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Minesweeper
    {
        static void Main(string[] args)
        {
            Minesweeper game = new Minesweeper();
            game.run();

            Console.ReadLine();
        }


        private void run()
        {
            Board board = new Board(6, 6);

            board.Render();

            // Loop
            // Read rows and cols
            Console.WriteLine("Write a row: ");
            int row = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write a col: ");
            int col = Int16.Parse(Console.ReadLine());

            // sweep box
            board.SweepBox(row, col);

            board.Render();
            Console.ReadLine();
        }
    }
}
