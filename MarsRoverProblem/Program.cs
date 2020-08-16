using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var platoSpaces = Console.ReadLine().Split(' ');

            var roverLocation = Console.ReadLine().Split(' ');

            var moveParams = Console.ReadLine().ToUpper();

            Location location = new Location()
            {
                X = Convert.ToInt16(roverLocation[0]),
                Y = Convert.ToInt16(roverLocation[1]),
                direction = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), roverLocation[2].ToUpper())
            };
            Position position = new Position();
            position.location = location;

            try
            {
                var lastPosition = position.ArrangePosition(Array.ConvertAll(platoSpaces, int.Parse), moveParams);
                Console.WriteLine($"{lastPosition.X} {lastPosition.Y} {lastPosition.direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
      
    }
}
