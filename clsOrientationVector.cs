using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoversApplication
{
    public enum enumOrientation { N, S, E, W };
    public enum enumSpin { L, R, M };

    class clsOrientationVector
    {
        private enumOrientation Orientation;

        public enumOrientation Coor_Orientation
        {
            get
            {
                return Orientation;
            }
            set
            {
                Orientation = value;
            }
        }

        public clsOrientationVector()
        {
            Orientation = enumOrientation.N;
        }

        public void TurnRigth()
        {
            switch (Orientation)
            {
                case enumOrientation.N:
                    Orientation = enumOrientation.E;
                    break;
                case enumOrientation.E:
                    Orientation = enumOrientation.S;
                    break;
                case enumOrientation.S:
                    Orientation = enumOrientation.W;
                    break;
                case enumOrientation.W:
                    Orientation = enumOrientation.N;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Orientation)
            {
                case enumOrientation.N:
                    Orientation = enumOrientation.W;
                    break;
                case enumOrientation.W:
                    Orientation = enumOrientation.S;
                    break;
                case enumOrientation.S:
                    Orientation = enumOrientation.E;
                    break;
                case enumOrientation.E:
                    Orientation = enumOrientation.N;
                    break;
            }
        }



    }


}
