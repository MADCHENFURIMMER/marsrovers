using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoversApplication
{
    class clsCoordinates
    {
        private int X;
        private int Y;

        public int Coor_X
        {
            get
            {
                return X;
            }

            set
            {
                X = value;
            }
        }

        public int Coor_Y
        {
            get
            {
                return Y;
            }

            set
            {
                Y = value;
            }
        }

        public clsCoordinates()
        {
            X = 0;
            Y = 0;
        }

    }
}
