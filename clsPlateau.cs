using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoversApplication
{
    class clsPlateau
    {
        private clsCoordinates UpperRight;
        private clsCoordinates LowerLeft;

        public clsCoordinates Coor_UpperRight
        {
            get
            {
                return UpperRight;
            }

        }

        public clsCoordinates Coor_LowerLeft
        {
            get
            {
                return LowerLeft;
            }

        }
        
        public clsPlateau(int X, int Y)
        {
            UpperRight = new clsCoordinates();
            LowerLeft = new clsCoordinates();

            UpperRight.Coor_X = X;
            UpperRight.Coor_Y = Y;
            LowerLeft.Coor_X = 0;
            LowerLeft.Coor_Y = 0;
        }


    }
}
