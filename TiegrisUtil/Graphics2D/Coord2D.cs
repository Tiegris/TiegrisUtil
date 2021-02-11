using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiegrisUtil.Graphics2D
{
    public struct Coord2D
    {
        public Coord2D(float x, float y) {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public static Coord2D operator -(Coord2D pont) {
            return new Coord2D(-pont.X, -pont.Y);
        }

        public static Coord2D operator -(Coord2D pont1, Coord2D pont2) {
            return new Coord2D(pont1.X - pont2.X, pont1.Y - pont2.Y);
        }

        public static Coord2D operator +(Coord2D pont1, Coord2D pont2) {
            return new Coord2D(pont1.X + pont2.X, pont1.Y + pont2.Y);
        }

        public static Coord2D operator *(Coord2D p, float a)
            => new Coord2D(p.X * a, p.Y * a);        
        public static Coord2D operator *(float a, Coord2D p) 
            => new Coord2D(p.X * a, p.Y * a);

        public static float Dot(Coord2D p1, Coord2D p2)
            => p1.X * p2.X + p1.Y * p2.Y;

        /// <summary>
        /// Distance from the Origin.
        /// </summary>
        public float Length {
            get => MathF.Sqrt(X * X + Y * Y);
        }

        public static float Distance(Coord2D p1, Coord2D p2) {
            return (p1 - p2).Length;
        }

        public static Coord2D Rotate(Coord2D p, float beta) {
            float temp_x = p.X * System.MathF.Cos(beta) - p.Y * System.MathF.Sin(beta);
            float y = p.X * System.MathF.Sin(beta) + p.Y * System.MathF.Cos(beta);
            float x = temp_x;
            return new Coord2D(x, y);
        }

    }
}
