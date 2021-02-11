using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiegrisUtil.Graphics2D
{
    public class Hitbox
    {
        public List<Coord2D> Outline { get; protected set; } = new List<Coord2D>();

        public bool Hit(Coord2D shoot) {
            return 
                hit(shoot, new Coord2D(1.9999f, 2.0001f)) || 
                hit(shoot, new Coord2D(shoot.Y, -1.9999f));
        }

        private bool hit(Coord2D hit, Coord2D infinity) {
            int cnt = 0;
            for (int i = 0; i < Outline.Count; i++) {
                var p0 = Outline[i];
                var p1 = Outline[(i + 1) % Outline.Count];
                if (LineSegment.Intersect(hit, infinity, p0, p1))
                    cnt++;
            }
            return cnt % 2 == 1;
        }
    }
}
