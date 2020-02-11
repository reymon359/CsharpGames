using System;

namespace Hangman
{
    internal class Word
    {
        private Letter[] letters;

        public Word(string secret_word)
        {
            letters = new Letter[secret_word.Length];
            for(int i = 0; i < secret_word.Length; i++)
            {
                letters[i] = new Letter(secret_word[i]);
            }
        }

        public override string ToString()
        {
            string msg = "";

            foreach (Letter letter in letters)
                msg += letter + " ";

            return msg;
        }

        internal void CheckIfContains(Letter read_letter)
        {
            foreach (Letter word_letter in letters)
                word_letter.HasSameValue(read_letter);
        }
    }
}