using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProblem
{
    public class Position
    {
        public Location location { get; set; }

        public Position()
        {
            location = new Location();
            location.X = location.Y = 0;
            location.direction = DirectionEnum.N;
        }

        public Location ArrangePosition(int[] platoSpaces, string moveParams)
        {
            foreach (var param in moveParams)
            {
                switch (param)
                {
                    case (char)MovementEnum.Left:
                        location.direction = MoveUtilities.TurnLeft90(location.direction);
                        break;
                    case (char)MovementEnum.Right:
                        location.direction = MoveUtilities.TurnRight90(location.direction);
                        break;
                    case (char)MovementEnum.Move:
                        location = MoveUtilities.MoveInDirection(location);
                        break;
                    default:
                        break;
                }
            }
            if (location.X < 0 || location.X > platoSpaces[0] || location.Y < 0 || location.Y > platoSpaces[1])
            {
                throw new Exception($"Position not found in space (0 , 0) and ({platoSpaces[0]} , {platoSpaces[1]})");
            }
            return location;
        }

    }
}
