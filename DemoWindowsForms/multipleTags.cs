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
                this.Controls.Add(lbls_letters[i]);
            }
        }
    }
}
