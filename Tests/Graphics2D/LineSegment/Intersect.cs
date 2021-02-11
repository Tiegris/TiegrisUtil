using NUnit.Framework;
using TiegrisUtil.Graphics2D;

namespace Tests
{
    public class Intersect
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
        public void Cross1() {            
            Assert.IsTrue(
                LineSegment.Intersect(LeftCenter, RightCenter, TopCenter, BottomCenter)
                );
        }

        [Test]
        public void Cross2() {
            Assert.IsTrue(
                LineSegment.Intersect(TopCenter, BottomCenter, LeftCenter, RightCenter)
                );
        }

        [Test]
        public void Slash() {
            Assert.IsFalse(
                LineSegment.Intersect(TopCenter, LeftCenter, RightCenter, BottomCenter)
                );
        }

        [Test]
        public void BackSlash() {
            Assert.IsFalse(
                LineSegment.Intersect(TopCenter, RightCenter, LeftCenter, BottomCenter)
                );
        }
    }
}