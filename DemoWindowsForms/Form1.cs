using Hangman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Word secret;

        public void initialization(object render, EventArgs e)
        {
            secret = new Word("house");
            lbl_word.Text = secret.ToString();
        }

        private void lbl_word_Click(object sender, EventArgs e)
        {
            string l = txt_letter.Text;
            Letter letter = new Letter(l[0]);
            secret.CheckIfContains(letter);
            lbl_word.Text = secret.ToString();

        }
      
    }

   
}
