using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        static void Main(string[] args)
        {
            Hangman game = new Hangman();
            game.run();

            Console.ReadLine();
        }

        private string secret_word = "house";

        private void run()
        {
            Word secret = new Word(secret_word);

            Console.WriteLine(secret);

            // Loop
            // putLetter
            // Visualice
        }
    }
}
