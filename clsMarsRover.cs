using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoversApplication
{
    class clsMarsRover
    {
        private clsCoordinates Coordinates;
        private clsOrientationVector Orientation;

        public clsCoordinates Rover_Coordinates
        {
            get
            {
                return Coordinates;
            }
        }

        public clsOrientationVector Rover_Orientation
        {
            get
            {
                return Orientation;
            }
        }

        public clsMarsRover()
        {
            Coordinates = new clsCoordinates();
            Orientation = new clsOrientationVector();
        }

        public void Move()
        {
            switch (Rover_Orientation.Coor_Orientation)
            {
                case enumOrientation.N:
                    Rover_Coordinates.Coor_Y = Rover_Coordinates.Coor_Y + 1;
                    break;
                case enumOrientation.S:
                    Rover_Coordinates.Coor_Y = Rover_Coordinates.Coor_Y - 1;
                    break;
                case enumOrientation.E:
                    Rover_Coordinates.Coor_X = Rover_Coordinates.Coor_X + 1;
                    break;
                case enumOrientation.W:
                    Rover_Coordinates.Coor_X = Rover_Coordinates.Coor_X - 1;
                    break;
            }
        }

        public void Spin(enumSpin Turn)
        {
            switch (Turn)
            {
                case enumSpin.L:
                    Rover_Orientation.TurnLeft();
                    break;
                case enumSpin.R:
                    Rover_Orientation.TurnRigth();
                    break;
                case enumSpin.M:
                    Move();
                    break;
            }
        }


    }
}
