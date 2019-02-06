namespace Hangman
{
    partial class startPage
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
            this.wordToBeGuessed = new System.Windows.Forms.TextBox();
            this.enterWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordToBeGuessed
            // 
            this.wordToBeGuessed.Location = new System.Drawing.Point(339, 116);
            this.wordToBeGuessed.Name = "wordToBeGuessed";
            this.wordToBeGuessed.Size = new System.Drawing.Size(218, 26);
            this.wordToBeGuessed.TabIndex = 0;
            // 
            // enterWord
            // 
            this.enterWord.AutoSize = true;
            this.enterWord.Location = new System.Drawing.Point(321, 62);
            this.enterWord.Name = "enterWord";
            this.enterWord.Size = new System.Drawing.Size(267, 20);
            this.enterWord.TabIndex = 1;
            this.enterWord.Text = "please enter the word to be guessed";
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.hangmangame;
            this.ClientSize = new System.Drawing.Size(643, 338);
            this.Controls.Add(this.enterWord);
            this.Controls.Add(this.wordToBeGuessed);
            this.Name = "startPage";
            this.Text = "startPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordToBeGuessed;
        private System.Windows.Forms.Label enterWord;
    }
}