using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiegrisUtil.Math;

namespace TiegrisUtil.Graphics2D
{
    public class LineSegment {

        private static double crossZ(Coord2D v1, Coord2D v2) {
            return v1.X * v2.Y - v1.Y * v2.X;
        }

        public static bool Intersect(Coord2D p11, Coord2D p12, Coord2D p21, Coord2D p22) {
            bool b1 = crossZ(p22 - p21, p11 - p21) * crossZ(p22 - p21, p12 - p21) <= 0;
            bool b2 = crossZ(p12 - p11, p21 - p11) * crossZ(p12 - p11, p22 - p11) <= 0;
            return b1 && b2;
        }
    }
}

