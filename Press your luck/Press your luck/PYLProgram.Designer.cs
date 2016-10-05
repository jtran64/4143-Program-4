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
            this.PlayerScreen1 = new System.Windows.Forms.Panel();
            this.player3NameBox = new System.Windows.Forms.TextBox();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.player2NameBox = new System.Windows.Forms.TextBox();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player1NameBox = new System.Windows.Forms.TextBox();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.backButton1 = new System.Windows.Forms.Button();
            this.player3Button = new System.Windows.Forms.Button();
            this.player2Button = new System.Windows.Forms.Button();
            this.fileScreen = new System.Windows.Forms.Panel();
            this.backButton3 = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.fileDirBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileDirLabel = new System.Windows.Forms.Label();
            this.startMenu.SuspendLayout();
            this.PlayerScreen1.SuspendLayout();
            this.fileScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(100, 85);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(170, 55);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(100, 146);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 55);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // startMenu
            // 
            this.startMenu.Controls.Add(this.PlayerScreen1);
            this.startMenu.Controls.Add(this.backButton1);
            this.startMenu.Controls.Add(this.player3Button);
            this.startMenu.Controls.Add(this.player2Button);
            this.startMenu.Location = new System.Drawing.Point(0, 0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(354, 399);
            this.startMenu.TabIndex = 2;
            this.startMenu.Visible = false;
            // 
            // PlayerScreen1
            // 
            this.PlayerScreen1.Controls.Add(this.fileScreen);
            this.PlayerScreen1.Controls.Add(this.player3NameBox);
            this.PlayerScreen1.Controls.Add(this.player3NameLabel);
            this.PlayerScreen1.Controls.Add(this.player2NameBox);
            this.PlayerScreen1.Controls.Add(this.player2NameLabel);
            this.PlayerScreen1.Controls.Add(this.player1NameLabel);
            this.PlayerScreen1.Controls.Add(this.player1NameBox);
            this.PlayerScreen1.Controls.Add(this.nextButton1);
            this.PlayerScreen1.Controls.Add(this.backButton2);
            this.PlayerScreen1.Location = new System.Drawing.Point(0, 0);
            this.PlayerScreen1.Name = "PlayerScreen1";
            this.PlayerScreen1.Size = new System.Drawing.Size(354, 399);
            this.PlayerScreen1.TabIndex = 3;
            this.PlayerScreen1.Visible = false;
            // 
            // player3NameBox
            // 
            this.player3NameBox.Location = new System.Drawing.Point(99, 181);
            this.player3NameBox.Name = "player3NameBox";
            this.player3NameBox.Size = new System.Drawing.Size(171, 20);
            this.player3NameBox.TabIndex = 7;
            this.player3NameBox.Visible = false;
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.AutoSize = true;
            this.player3NameLabel.Location = new System.Drawing.Point(97, 165);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(76, 13);
            this.player3NameLabel.TabIndex = 6;
            this.player3NameLabel.Text = "Player 3 Name";
            this.player3NameLabel.Visible = false;
            // 
            // player2NameBox
            // 
            this.player2NameBox.Location = new System.Drawing.Point(99, 122);
            this.player2NameBox.Name = "player2NameBox";
            this.player2NameBox.Size = new System.Drawing.Size(171, 20);
            this.player2NameBox.TabIndex = 5;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Location = new System.Drawing.Point(97, 106);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(76, 13);
            this.player2NameLabel.TabIndex = 4;
            this.player2NameLabel.Text = "Player 2 Name";
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Location = new System.Drawing.Point(97, 43);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(76, 13);
            this.player1NameLabel.TabIndex = 3;
            this.player1NameLabel.Text = "Player 1 Name";
            // 
            // player1NameBox
            // 
            this.player1NameBox.Location = new System.Drawing.Point(99, 59);
            this.player1NameBox.Name = "player1NameBox";
            this.player1NameBox.Size = new System.Drawing.Size(171, 20);
            this.player1NameBox.TabIndex = 2;
            // 
            // nextButton1
            // 
            this.nextButton1.Location = new System.Drawing.Point(267, 366);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(75, 23);
            this.nextButton1.TabIndex = 1;
            this.nextButton1.Text = "Next";
            this.nextButton1.UseVisualStyleBackColor = true;
            this.nextButton1.Click += new System.EventHandler(this.nextButton1_Click);
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(12, 366);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 23);
            this.backButton2.TabIndex = 0;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(100, 210);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(170, 55);
            this.backButton1.TabIndex = 2;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton_Click);
            // 
            // player3Button
            // 
            this.player3Button.Location = new System.Drawing.Point(100, 146);
            this.player3Button.Name = "player3Button";
            this.player3Button.Size = new System.Drawing.Size(170, 55);
            this.player3Button.TabIndex = 1;
            this.player3Button.Text = "3 Player Game";
            this.player3Button.UseVisualStyleBackColor = true;
            this.player3Button.Click += new System.EventHandler(this.player3Button_Click);
            // 
            // player2Button
            // 
            this.player2Button.Location = new System.Drawing.Point(100, 85);
            this.player2Button.Name = "player2Button";
            this.player2Button.Size = new System.Drawing.Size(170, 55);
            this.player2Button.TabIndex = 0;
            this.player2Button.Text = "2 Player Game";
            this.player2Button.UseVisualStyleBackColor = true;
            this.player2Button.Click += new System.EventHandler(this.player2Button_Click);
            // 
            // fileScreen
            // 
            this.fileScreen.Controls.Add(this.fileDirLabel);
            this.fileScreen.Controls.Add(this.fileLabel);
            this.fileScreen.Controls.Add(this.fileDirBox);
            this.fileScreen.Controls.Add(this.fileNameBox);
            this.fileScreen.Controls.Add(this.openFileButton);
            this.fileScreen.Controls.Add(this.startGameButton);
            this.fileScreen.Controls.Add(this.backButton3);
            this.fileScreen.Location = new System.Drawing.Point(0, 0);
            this.fileScreen.Name = "fileScreen";
            this.fileScreen.Size = new System.Drawing.Size(354, 399);
            this.fileScreen.TabIndex = 8;
            this.fileScreen.Visible = false;
            // 
            // backButton3
            // 
            this.backButton3.Location = new System.Drawing.Point(12, 366);
            this.backButton3.Name = "backButton3";
            this.backButton3.Size = new System.Drawing.Size(75, 23);
            this.backButton3.TabIndex = 0;
            this.backButton3.Text = "Back";
            this.backButton3.UseVisualStyleBackColor = true;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(267, 366);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(16, 33);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(100, 33);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(190, 20);
            this.fileNameBox.TabIndex = 3;
            // 
            // fileDirBox
            // 
            this.fileDirBox.Location = new System.Drawing.Point(100, 83);
            this.fileDirBox.Name = "fileDirBox";
            this.fileDirBox.Size = new System.Drawing.Size(190, 20);
            this.fileDirBox.TabIndex = 4;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(97, 17);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(54, 13);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "File Name";
            // 
            // fileDirLabel
            // 
            this.fileDirLabel.AutoSize = true;
            this.fileDirLabel.Location = new System.Drawing.Point(97, 67);
            this.fileDirLabel.Name = "fileDirLabel";
            this.fileDirLabel.Size = new System.Drawing.Size(68, 13);
            this.fileDirLabel.TabIndex = 6;
            this.fileDirLabel.Text = "File Directory";
            // 
            // PYLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 401);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "PYLForm";
            this.Text = "Press Your Luck";
            this.startMenu.ResumeLayout(false);
            this.PlayerScreen1.ResumeLayout(false);
            this.PlayerScreen1.PerformLayout();
            this.fileScreen.ResumeLayout(false);
            this.fileScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button player3Button;
        private System.Windows.Forms.Button player2Button;
        private System.Windows.Forms.Panel PlayerScreen1;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.TextBox player1NameBox;
        private System.Windows.Forms.Button nextButton1;
        private System.Windows.Forms.TextBox player3NameBox;
        private System.Windows.Forms.Label player3NameLabel;
        private System.Windows.Forms.TextBox player2NameBox;
        private System.Windows.Forms.Panel fileScreen;
        private System.Windows.Forms.Label fileDirLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileDirBox;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button backButton3;
    }
}

