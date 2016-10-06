using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Press_your_luck
{
    class Board
    {
        private BoardSpace[] Pieces = new BoardSpace[35];
        private BoardSpace[] Whammy = new BoardSpace[5];
        public BoardSpace[] Selection = new BoardSpace[18];
        private BoardSpace[] newPieces = new BoardSpace[18];
 
        public Board(int num)
        {
            Builder();
            Randomize(Whammy);
            if (num == 1)
                for (int x = 0; x < 18; x++)
                    newPieces[x] = Pieces[x];
            else
                for (int y = 0; y < 18; y++)
                    newPieces[y] = Pieces[y + 17];
            Randomize(newPieces);
            for (int z = 0; z < Selection.Length; z++)
            {
                    if (z < 4)
                        Selection[z] = Whammy[z];
                    else
                        Selection[z] = newPieces[z];
            }
            Randomize(Selection);
        }
 
        private void Builder()
        {
            Pieces[0].image = Properties.Resources._470G;
            Pieces[0].value = 470;
            Pieces[1].image = Properties.Resources._500G;
            Pieces[1].value = 500;
            Pieces[2].image = Properties.Resources._500G_1Spin;
            Pieces[2].value = 500;
            Pieces[2].spin = true;
            Pieces[3].image = Properties.Resources._525G;
            Pieces[3].value = 525;
            Pieces[4].image = Properties.Resources._530G;
            Pieces[4].value = 530;
            Pieces[5].image = Properties.Resources._650G;
            Pieces[5].value = 650;
            Pieces[6].image = Properties.Resources._740G;
            Pieces[6].value = 740;
            Pieces[7].image = Properties.Resources._750G;
            Pieces[7].value = 750;
            Pieces[8].image = Properties.Resources._750G_Spin;
            Pieces[8].value = 750;
            Pieces[8].spin = true;
            Pieces[9].image = Properties.Resources._800G;
            Pieces[9].value = 800;
            Pieces[10].image = Properties.Resources._900G;
            Pieces[10].value = 900;
            Pieces[11].image = Properties.Resources._1000G;
            Pieces[11].value = 1000;
            Pieces[12].image = Properties.Resources._1000G_Spin;
            Pieces[12].value = 1000;
            Pieces[12].spin = true;
            Pieces[13].image = Properties.Resources._1100G;
            Pieces[13].value = 1100;
            Pieces[14].image = Properties.Resources._1200G;
            Pieces[14].value = 1200;
            Pieces[15].image = Properties.Resources._1250G;
            Pieces[15].value = 1250;
            Pieces[16].image = Properties.Resources._1300G;
            Pieces[16].value = 1300;
            Pieces[17].image = Properties.Resources._1400G;
            Pieces[17].value = 1400;
            Pieces[18].image = Properties.Resources._1500G;
            Pieces[18].value = 1500;
            Pieces[19].image = Properties.Resources._1500G_Spin;
            Pieces[19].value = 1500;
            Pieces[19].spin = true;
            Pieces[20].image = Properties.Resources._1600G;
            Pieces[20].value = 1600;
            Pieces[21].image = Properties.Resources._1750G;
            Pieces[21].value = 1750;
            Pieces[22].image = Properties.Resources._1750G_Spin;
            Pieces[22].value = 1750;
            Pieces[22].spin = true;
            Pieces[23].image = Properties.Resources._1900G;
            Pieces[23].value = 1900;
            Pieces[24].image = Properties.Resources._2000G;
            Pieces[24].value = 2000;
            Pieces[25].image = Properties.Resources._2000G_Spin;
            Pieces[25].value = 2000;
            Pieces[25].spin = true;
            Pieces[26].image = Properties.Resources._2250G;
            Pieces[26].value = 2250;
            Pieces[27].image = Properties.Resources._2500G;
            Pieces[27].value = 2500;
            Pieces[28].image = Properties.Resources._2500G_Spin;
            Pieces[28].value = 2500;
            Pieces[28].spin = true;
            Pieces[29].image = Properties.Resources._2750G;
            Pieces[29].value = 2750;
            Pieces[30].image = Properties.Resources._3000G;
            Pieces[30].value = 3000;
            Pieces[31].image = Properties.Resources._3000G_Spin;
            Pieces[31].value = 3000;
            Pieces[31].spin = true;
            Pieces[32].image = Properties.Resources._3500G;
            Pieces[32].value = 3500;
            Pieces[33].image = Properties.Resources._4000G;
            Pieces[33].value = 4000;
            Pieces[34].image = Properties.Resources._4000G_Spin;
            Pieces[34].value = 4000;
 
            Whammy[0].image = Properties.Resources.Whammy1;
            Whammy[0].whammy = true;
            Whammy[1].image = Properties.Resources.Whammy2;
            Whammy[1].whammy = true;
            Whammy[2].image = Properties.Resources.Whammy3;
            Whammy[2].whammy = true;
            Whammy[3].image = Properties.Resources.Whammy4;
            Whammy[3].whammy = true;
            Whammy[4].image = Properties.Resources.Whammy5;
            Whammy[4].whammy = true;
        }
 
        private void Randomize(BoardSpace[] items)
        {
            Random rand = new Random();
 
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                BoardSpace temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
 
    }
}
