using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Press_your_luck
{
    class BoardSpace
    {
        private int _value = 0;
        private bool _spin = false;
        private bool _whammy = false;
        private Image _image;

        public int value
        {
            get { return _value; }
            set { _value = value; }
        }

        public bool spin
        {
            get { return _spin; }
            set { _spin = value; }
        }

        public bool whammy
        {
            get { return _whammy; }
            set { _whammy = value; }
        }

        public Image image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
