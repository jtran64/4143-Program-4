using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Press_your_luck
{
    public partial class PYLBoardForm : Form
    {
        Dictionary<string, string> QandA = new Dictionary<string, string>();
        int numQuestions = 0;
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();
        Board board = new Board(1);

        public PYLBoardForm(Dictionary<string, string> dict, string p1name, string p2name, string p3name)
        {
            player1.name = p1name;
            player2.name = p2name;
            player3.name = p3name;
            QandA = dict;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextQButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randNum;
            randNum = rand.Next(0, QandA.Count);
            questionBox.Text = QandA.Keys.ElementAt(randNum);
            numQuestions++;
            if (numQuestions == 4)
            {
                nextQButton.Visible = false;
                startSpinButton.Visible = true;
            }
        }

        private void round1Button_Click(object sender, EventArgs e)
        {
            round1Button.Visible = false;
            Random rand = new Random();
            int randNum;
            randNum = rand.Next(0, QandA.Count);
            questionBox.Text = QandA.Keys.ElementAt(randNum);
            numQuestions++;

        }

        private void startSpinButton_Click(object sender, EventArgs e)
        {
            int p1Spins = player1.numSpins;
            int p2Spins = player2.numSpins;
            int p3Spins = player3.numSpins;
            
        }


    }
}
