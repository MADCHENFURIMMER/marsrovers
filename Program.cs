using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoversApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> InputList = new List<string>();

            Console.WriteLine("Test Input:");
            GetInputLines(InputList);

            Console.WriteLine("Expected Output:");
            PrintOutputLines(InputList);

            Console.WriteLine("==========");
            Console.ReadLine();
        }

        private static void PrintOutputLines(List<string> InputList)
        {
            for (int InputLineIndex = 0; InputLineIndex < InputList.Count; InputLineIndex++)
            {
                clsPlateau PlateauObject = new clsPlateau(0, 0);
                clsMarsRover RoverObject = new clsMarsRover();

                if ((InputLineIndex == 0) && (InputList[InputLineIndex].Split(' ').Length == 2))
                    PlateauObject = new clsPlateau(int.Parse(InputList[InputLineIndex].Split(' ')[0]), int.Parse(InputList[InputLineIndex].Split(' ')[1]));

                if ((InputLineIndex % 2) == 0)
                    continue;

                if (InputList[InputLineIndex].Split(' ').Length < 3)
                    continue;

                RoverObject.Rover_Coordinates.Coor_X = int.Parse(InputList[InputLineIndex].Split(' ')[0]);
                RoverObject.Rover_Coordinates.Coor_Y = int.Parse(InputList[InputLineIndex].Split(' ')[1]);
                RoverObject.Rover_Orientation.Coor_Orientation = (enumOrientation)Enum.Parse(typeof(enumOrientation), InputList[InputLineIndex].Split(' ')[2]);

                for (int InstructionLetterIndex = 0; InstructionLetterIndex < InputList[InputLineIndex + 1].Length; InstructionLetterIndex++)
                    RoverObject.Spin((enumSpin)Enum.Parse(typeof(enumSpin), InputList[InputLineIndex + 1][InstructionLetterIndex].ToString()));

                Console.WriteLine(RoverObject.Rover_Coordinates.Coor_X.ToString() + " " + RoverObject.Rover_Coordinates.Coor_Y.ToString() + " " + RoverObject.Rover_Orientation.Coor_Orientation.ToString());
            }
        }

        private static void GetInputLines(List<string> InputList)
        {
            string line = "";

            do
            {
                Console.Write("");
                line = Console.ReadLine();
                if (line != null)
                    InputList.Add(line);
            } while (line != "");
        }

    }
}

