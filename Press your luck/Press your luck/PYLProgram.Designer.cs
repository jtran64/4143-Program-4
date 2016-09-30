namespace Press_your_luck
{
    partial class PYLForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startMenu = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.player3Button = new System.Windows.Forms.Button();
            this.player2Button = new System.Windows.Forms.Button();
            this.startMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(95, 132);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 71);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(95, 223);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 72);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // startMenu
            // 
            this.startMenu.Controls.Add(this.backButton);
            this.startMenu.Controls.Add(this.player3Button);
            this.startMenu.Controls.Add(this.player2Button);
            this.startMenu.Location = new System.Drawing.Point(0, 0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(354, 399);
            this.startMenu.TabIndex = 2;
            this.startMenu.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(83, 210);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(172, 57);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // player3Button
            // 
            this.player3Button.Location = new System.Drawing.Point(83, 146);
            this.player3Button.Name = "player3Button";
            this.player3Button.Size = new System.Drawing.Size(172, 57);
            this.player3Button.TabIndex = 1;
            this.player3Button.Text = "3 Player Game";
            this.player3Button.UseVisualStyleBackColor = true;
            // 
            // player2Button
            // 
            this.player2Button.Location = new System.Drawing.Point(83, 85);
            this.player2Button.Name = "player2Button";
            this.player2Button.Size = new System.Drawing.Size(172, 55);
            this.player2Button.TabIndex = 0;
            this.player2Button.Text = "2 Player Game";
            this.player2Button.UseVisualStyleBackColor = true;
            // 
            // PYLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 399);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "PYLForm";
            this.Text = "Press Your Luck";
            this.startMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button player3Button;
        private System.Windows.Forms.Button player2Button;
    }
}

