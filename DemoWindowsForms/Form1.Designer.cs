namespace DemoWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addLetter = new System.Windows.Forms.Button();
            this.lbl_word = new System.Windows.Forms.Label();
            this.txt_letter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addLetter
            // 
            this.btn_addLetter.Location = new System.Drawing.Point(325, 266);
            this.btn_addLetter.Name = "btn_addLetter";
            this.btn_addLetter.Size = new System.Drawing.Size(100, 23);
            this.btn_addLetter.TabIndex = 0;
            this.btn_addLetter.Text = "Add Letter";
            this.btn_addLetter.UseVisualStyleBackColor = true;
            this.btn_addLetter.Click += new System.EventHandler(this.lbl_word_Click);
            // 
            // lbl_word
            // 
            this.lbl_word.AccessibleName = "";
            this.lbl_word.AutoSize = true;
            this.lbl_word.Location = new System.Drawing.Point(353, 111);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(46, 17);
            this.lbl_word.TabIndex = 1;
            this.lbl_word.Text = "label1";
            this.lbl_word.Click += new System.EventHandler(this.lbl_word_Click);
            // 
            // txt_letter
            // 
            this.txt_letter.Location = new System.Drawing.Point(304, 198);
            this.txt_letter.Name = "txt_letter";
            this.txt_letter.Size = new System.Drawing.Size(139, 22);
            this.txt_letter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_letter);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.btn_addLetter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.initialization);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addLetter;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.TextBox txt_letter;
    }
}

