using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Press_your_luck
{
    public partial class PYLForm : Form
    {
        Dictionary<string, string> QandA = new Dictionary<string,string>();
        bool numPlayers3 = false;
        string p1Name;
        string p2Name;
        string p3Name;
        

        public PYLForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startMenu.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            startMenu.Visible = false;
        }

        private void player2Button_Click(object sender, EventArgs e)
        {
            PlayerScreen1.Visible = true;
        }

        private void player3Button_Click(object sender, EventArgs e)
        {
            numPlayers3 = true;
            player3NameBox.Visible = true;
            player3NameLabel.Visible = true;
            PlayerScreen1.Visible = true;
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            p1Name = "";
            p2Name = "";
            p3Name = "";
            PlayerScreen1.Visible = false;
            player3NameBox.Visible = false;
            player3NameLabel.Visible = false;
            numPlayers3 = false;
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            p1Name = player1NameBox.Text;
            p2Name = player2NameBox.Text;
            p3Name = player3NameBox.Text;
            fileScreen.Visible = true;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            fileScreen.Visible = false;
            fileNameBox.Text = "";
            fileDirBox.Text = "";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string question;
                string answer;
                string fileName = OFD.FileName;

                fileNameBox.Text = OFD.SafeFileName;
                fileDirBox.Text = OFD.FileName;

                StreamReader reader = new StreamReader(fileName);
                while ((question = reader.ReadLine()) != null)
                {
                    if ((answer = reader.ReadLine()) != null) 
                        if (answer != "" && question != "")
                            QandA.Add(question, answer);
                }
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            PYLBoardForm board = new PYLBoardForm(QandA, p1Name, p2Name, p3Name);
            board.P1NameBox.Text = p1Name;
            board.P2NameBox.Text = p2Name;
            if (numPlayers3 == true)
            {
                board.P3NameBox.Visible = true;
                board.P3MoneyBox.Visible = true;
                board.P3Spins.Visible = true;
                board.P3PassSpins.Visible = true;
                board.P3NameBox.Text = p3Name;
            }
            //Randomize board 
            board.Visible = true;
            this.Visible = false;
        }

            
    }
}
