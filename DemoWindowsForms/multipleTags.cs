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
    public partial class multipleTags : Form
    {
        private static string chain = "house";
        private Word secret = new Word(chain);
        private Label[] lbls_letters = new Label[chain.Length];
        public multipleTags()
        {
            InitializeComponent();
            InitializeMyComponents();
        }

        private void InitializeMyComponents()
        {
            for(int i=0; i < lbls_letters.Length; i++)
            {
                lbls_letters[i] = new Label();
                lbls_letters[i].Text = "" + i;
                lbls_letters[i].AutoSize = true;
                // this.Controls.Add(lbls_letters[i]);
                this.flowLayoutPanel_letters.Controls.Add(lbls_letters[i]);

            }
        }

        private void multipleTags_Load(object sender, EventArgs e)
        {
            string res = secret.ToString();

            for(int i = 0; i < lbls_letters.Length; i++)
            {
                // lbls_letters[i].Text = secret.GetLetter(i).ToString();
                lbls_letters[i].Text = "" + secret.ToString()[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secret.CheckIfContains(new Letter(txt_letter.Text[0]));
            for (int i = 0; i < lbls_letters.Length; i++)
            {
                lbls_letters[i].Text = secret.getLetterFromPosition(i);
            }
            Form1 window = new Form1();
            window.Show();
        }
    }
}
