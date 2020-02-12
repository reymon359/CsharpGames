namespace DemoWindowsForms
{
    partial class multipleTags
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_letter = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_letters = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_letter
            // 
            this.txt_letter.Location = new System.Drawing.Point(332, 252);
            this.txt_letter.Name = "txt_letter";
            this.txt_letter.Size = new System.Drawing.Size(100, 22);
            this.txt_letter.TabIndex = 1;
            // 
            // flowLayoutPanel_letters
            // 
            this.flowLayoutPanel_letters.Location = new System.Drawing.Point(246, 81);
            this.flowLayoutPanel_letters.Name = "flowLayoutPanel_letters";
            this.flowLayoutPanel_letters.Size = new System.Drawing.Size(275, 46);
            this.flowLayoutPanel_letters.TabIndex = 2;
            // 
            // multipleTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_letters);
            this.Controls.Add(this.txt_letter);
            this.Controls.Add(this.button1);
            this.Name = "multipleTags";
            this.Text = "multipleTags";
            this.Load += new System.EventHandler(this.multipleTags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_letter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_letters;
    }
}