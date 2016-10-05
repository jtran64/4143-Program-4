using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Press_your_luck
{
    class Player
    {
        private string _name;
        private int _money;
        private int _numWhammy;
        private int _numSpins;
        private int _numPassedSpins;

        public Player()
        {
            name = "";
            money = 0;
            numWhammy = 0;
            numSpins = 0;
            numPassedSpins = 0;
        }
        public Player(string Name)
        {
            name = Name;
            money = 0;
            numWhammy = 0;
            numSpins = 0;
            numPassedSpins = 0;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int money
        {
            get { return _money; }
            set { _money = value; }
        }

        public int numWhammy
        {
            get { return _numWhammy; }
            set { _numWhammy = value; }
        }

        public int numSpins
        {
            get { return _numSpins; }
            set { _numSpins = value; }
        }

        public int numPassedSpins
        {
            get { return _numPassedSpins; }
            set { _numPassedSpins = value; }
        }
    }
}
