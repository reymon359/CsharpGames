using System;

namespace Hangman
{
    public class Letter
    {
        private char value;
        private bool guessed;

        public Letter(char v)
        {
            this.value = v;
            this.guessed = false;
        }

        public override string ToString()
        {
            if (this.guessed)
                return "" + this.value;
            else return "-";
        }

        internal void HasSameValue(Letter read_letter)
        {
            if (this.value == read_letter.value)
                this.guessed = true;
        }
    }
}