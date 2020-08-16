using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRoverProblem.Program;

namespace MarsRoverProblem
{
    public static class MoveUtilities
    {

        public static DirectionEnum TurnLeft90(DirectionEnum direction)
        {
            DirectionEnum newDirection = direction;
            switch (direction)
            {
                case DirectionEnum.N:
                    newDirection = DirectionEnum.W;
                    break;
                case DirectionEnum.S:
                    newDirection = DirectionEnum.E;
                    break;
                case DirectionEnum.E:
                    newDirection = DirectionEnum.N;
                    break;
                case DirectionEnum.W:
                    newDirection = DirectionEnum.S;
                    break;
                default:
                    break;
            }
            return newDirection;
        }

        public static DirectionEnum TurnRight90(DirectionEnum direction)
        {
            DirectionEnum newDirections = direction;
            switch (direction)
            {
                case DirectionEnum.N:
                    newDirections = DirectionEnum.E;
                    break;
                case DirectionEnum.S:
                    newDirections = DirectionEnum.W;
                    break;
                case DirectionEnum.E:
                    newDirections = DirectionEnum.S;
                    break;
                case DirectionEnum.W:
                    newDirections = DirectionEnum.N;
                    break;
                default:
                    break;
            }

            return newDirections;
        }

        public static Location MoveInDirection(Location location)
        {
            switch (location.direction)
            {
                case DirectionEnum.N:
                    location.Y += 1;
                    break;
                case DirectionEnum.S:
                    location.Y -= 1;
                    break;
                case DirectionEnum.E:
                    location.X += 1;
                    break;
                case DirectionEnum.W:
                    location.X -= 1;
                    break;
                default:
                    break;
            }

            return new Location()
            {
                X = location.X,
                Y = location.Y,
                direction = location.direction
            };
        }
    }
}
