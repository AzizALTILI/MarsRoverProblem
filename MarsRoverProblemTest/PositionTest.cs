using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverProblem;

namespace MarsRoverProblemTest
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void Position_StartMoving()
        {
            int[] platospace = new int[]{5,5};

            string moveParams = "LMLMLMLMM";
           
            Location location = new Location()
            {
                X = 1,
                Y = 2,
                direction = DirectionEnum.N
            };

            var expected = new Location()
            {
                X = 1,
                Y = 3,
                direction = DirectionEnum.N
            };
            Position position = new Position();
            position.location = location;


            var actual = position.ArrangePosition(platospace, moveParams);

            Assert.AreEqual(expected.X, actual.X, "Position X not correct");
            Assert.AreEqual(expected.Y, actual.Y, "Position Y not correct");
            Assert.AreEqual(expected.direction, actual.direction, "Position direction not correct");

        }

        [TestMethod]
        public void Position_StartMoving_2()
        {
            int[] platospace = new int[] { 5, 5 };

            string moveParams = "MMRMMRMRRM";

            Location location = new Location()
            {
                X = 3,
                Y = 3,
                direction = DirectionEnum.E
            };

            var expected = new Location()
            {
                X = 5,
                Y = 1,
                direction = DirectionEnum.E
            };
            Position position = new Position();
            position.location = location;


            var actual = position.ArrangePosition(platospace, moveParams);

            Assert.AreEqual(expected.X, actual.X, "Position X not correct");
            Assert.AreEqual(expected.Y, actual.Y, "Position Y not correct");
            Assert.AreEqual(expected.direction, actual.direction, "Position direction not correct");

        }
    }
}
