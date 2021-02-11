using NUnit.Framework;
using TiegrisUtil.Graphics2D;

namespace Tests
{
    public class Hit
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

        Hitbox Diamond;
        Hitbox UpArrow;

        [OneTimeSetUp]
        public void ShapeDiamond_Setup() {
            var hitbox = new Hitbox();
            hitbox.Outline.Add(TopCenter);
            hitbox.Outline.Add(RightCenter);
            hitbox.Outline.Add(BottomCenter);
            hitbox.Outline.Add(LeftCenter);
            Diamond = hitbox;
        }

        [OneTimeSetUp]
        public void ShapeUpArrow_Setup() {
            var hitbox = new Hitbox();
            hitbox.Outline.Add(TopCenter);
            hitbox.Outline.Add(BottomRight);
            hitbox.Outline.Add(Center);
            hitbox.Outline.Add(BottomLeft);
            UpArrow = hitbox;
        }

        [Test]
        public void ShapeDiamond_HitCenter() {
            Assert.IsTrue(Diamond.Hit(Center));
        }

        [Test]
        public void ShapeDiamond_HitTopright() {
            Assert.IsFalse(Diamond.Hit(TopRight));
        }

        [Test]
        public void ShapeUpArrow_HitCenterSlightlyAbowe() {
            Assert.IsTrue(UpArrow.Hit(new Coord2D(0, 0.0001f)));
        }

        [Test]
        public void ShapeUpArrow_HitCenterSlightlyBelow() {
            Assert.IsFalse(UpArrow.Hit(new Coord2D(0, -0.0001f)));
        }

        [Test]
        public void ShapeUpArrow_HitTopright() {
            Assert.IsFalse(UpArrow.Hit(TopRight));
        }
    }
}
