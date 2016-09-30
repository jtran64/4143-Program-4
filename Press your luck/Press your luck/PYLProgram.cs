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
    public partial class PYLForm : Form
    {
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

        Player player1 = new Player("Johnny", "Tran");
        Player player2 = new Player("player", "two");
        Player player3 = new Player("player", "three");


        
    }
}
