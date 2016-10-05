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
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();
        Dictionary<string, string> QandA = new Dictionary<string,string>();
        bool numPlayers3 = false;
        

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
            player1NameBox.Text = "";
            player2NameBox.Text = "";
            player3NameBox.Text = "";
            PlayerScreen1.Visible = false;
            player3NameBox.Visible = false;
            player3NameLabel.Visible = false;
            numPlayers3 = false;
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            player1.name = player1NameBox.Text;
            player2.name = player2NameBox.Text;
            player3.name = player3NameBox.Text;
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
                    if ((answer = reader.ReadLine()) != null) ;
                    if (answer != "" && question != "")
                        QandA.Add(question, answer);
                }
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            PYLBoardForm board = new PYLBoardForm();
            board.P1NameBox.Text = player1.name;
            board.P2NameBox.Text = player2.name;
            if (numPlayers3 == true)
            {
                board.P3NameBox.Visible = true;
                board.P3MoneyBox.Visible = true;
                board.P3Spins.Visible = true;
                board.P3PassSpins.Visible = true;
                board.P3NameBox.Text = player3.name;
            }
            //Randomize board 
            board.Visible = true;
        }

            
    }
}
