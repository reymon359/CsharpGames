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

            for(; ; )
            {
                // putLetter
                Console.WriteLine("Write a letter: ");
                char letter = Console.ReadLine()[0];
                Letter read_letter = new Letter(letter);

                secret.CheckIfContains(read_letter);
                // Visualice
                Console.WriteLine(secret);
            }
        }
    }
}
