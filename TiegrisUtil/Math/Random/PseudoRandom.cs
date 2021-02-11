using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiegrisUtil.Math
{
    public class PseudoRandom : IRandom
    {
        private readonly System.Random ran;

        public PseudoRandom(int seed) {
            ran = new System.Random(seed);
        }

        public PseudoRandom() {
            ran = new System.Random();
        }

        public int ContinuousInt() => ran.Next();
        public int ContinuousInt(int min, int max) => ran.Next(min, max);

        public double GaussianDobule() {
            double u1 = 1.0 - ran.NextDouble();
            double u2 = 1.0 - ran.NextDouble();
            return System.Math.Sqrt(-2.0 * System.Math.Log(u1)) * System.Math.Sin(2.0 * System.Math.PI * u2);
        }

        public bool ContinuousChance(int percent) => ran.Next(0, 100) < percent;
        public bool ContinuousChance(double probability) => ran.NextDouble() < probability;

        public double ContinuousDouble() {
            return ran.NextDouble();
        }
    }
}
