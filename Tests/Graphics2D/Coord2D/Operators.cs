using NUnit.Framework;
using TiegrisUtil.Graphics2D;

namespace Tests
{
    public class Operators
    {
        Coord2D TopLeft = new Coord2D(-1, 1);
        Coord2D TopRight = new Coord2D(1, 1);
        Coord2D BottomLeft = new Coord2D(-1, -1);
        Coord2D BottomRight = new Coord2D(1, -1);
        Coord2D Center = new Coord2D(0, 0);
        Coord2D TopCenter = new Coord2D(0, 1);
        Coord2D BottomCenter = new Coord2D(0, -1);
        Coord2D RightCenter = new Coord2D(1, 0);
        Coord2D LeftCenter = new Coord2D(-1, 0);

        [Test]
        public void Operator_Star() {
            var a = Center * 1;
            var b = 2 * Center;
        }
    }
}
