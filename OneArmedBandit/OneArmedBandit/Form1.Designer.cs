namespace OneArmedBandit
{
    partial class Form1
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
            this.imageOne = new System.Windows.Forms.PictureBox();
            this.imageThree = new System.Windows.Forms.PictureBox();
            this.imageTwo = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.nudgeBoxOne = new System.Windows.Forms.Button();
            this.nudgeBoxTwo = new System.Windows.Forms.Button();
            this.nudgeBoxThree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageOne
            // 
            this.imageOne.InitialImage = null;
            this.imageOne.Location = new System.Drawing.Point(80, 47);
            this.imageOne.Name = "imageOne";
            this.imageOne.Size = new System.Drawing.Size(335, 240);
            this.imageOne.TabIndex = 0;
            this.imageOne.TabStop = false;
            // 
            // imageThree
            // 
            this.imageThree.Location = new System.Drawing.Point(874, 47);
            this.imageThree.Name = "imageThree";
            this.imageThree.Size = new System.Drawing.Size(335, 240);
            this.imageThree.TabIndex = 1;
            this.imageThree.TabStop = false;
            // 
            // imageTwo
            // 
            this.imageTwo.Location = new System.Drawing.Point(480, 47);
            this.imageTwo.Name = "imageTwo";
            this.imageTwo.Size = new System.Drawing.Size(335, 240);
            this.imageTwo.TabIndex = 2;
            this.imageTwo.TabStop = false;
            // 
            // spinButton
            // 
            this.spinButton.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(514, 477);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(263, 98);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // nudgeBoxOne
            // 
            this.nudgeBoxOne.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeBoxOne.Location = new System.Drawing.Point(158, 309);
            this.nudgeBoxOne.Name = "nudgeBoxOne";
            this.nudgeBoxOne.Size = new System.Drawing.Size(147, 69);
            this.nudgeBoxOne.TabIndex = 4;
            this.nudgeBoxOne.Text = "Nudge";
            this.nudgeBoxOne.UseVisualStyleBackColor = true;
            this.nudgeBoxOne.Click += new System.EventHandler(this.nudgeBoxOne_Click);
            // 
            // nudgeBoxTwo
            // 
            this.nudgeBoxTwo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeBoxTwo.Location = new System.Drawing.Point(570, 309);
            this.nudgeBoxTwo.Name = "nudgeBoxTwo";
            this.nudgeBoxTwo.Size = new System.Drawing.Size(163, 69);
            this.nudgeBoxTwo.TabIndex = 5;
            this.nudgeBoxTwo.Text = "Nudge";
            this.nudgeBoxTwo.UseVisualStyleBackColor = true;
            this.nudgeBoxTwo.Click += new System.EventHandler(this.nudgeBoxTwo_Click);
            // 
            // nudgeBoxThree
            // 
            this.nudgeBoxThree.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeBoxThree.Location = new System.Drawing.Point(990, 309);
            this.nudgeBoxThree.Name = "nudgeBoxThree";
            this.nudgeBoxThree.Size = new System.Drawing.Size(156, 69);
            this.nudgeBoxThree.TabIndex = 6;
            this.nudgeBoxThree.Text = "Nudge";
            this.nudgeBoxThree.UseVisualStyleBackColor = true;
            this.nudgeBoxThree.Click += new System.EventHandler(this.nudgeBoxThree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1241, 633);
            this.Controls.Add(this.nudgeBoxThree);
            this.Controls.Add(this.nudgeBoxTwo);
            this.Controls.Add(this.nudgeBoxOne);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.imageTwo);
            this.Controls.Add(this.imageThree);
            this.Controls.Add(this.imageOne);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageOne;
        private System.Windows.Forms.PictureBox imageThree;
        private System.Windows.Forms.PictureBox imageTwo;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button nudgeBoxOne;
        private System.Windows.Forms.Button nudgeBoxTwo;
        private System.Windows.Forms.Button nudgeBoxThree;
    }
}

