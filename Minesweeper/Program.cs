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
            // see box

            board.Render();
            Console.ReadLine();
        }
    }
}
