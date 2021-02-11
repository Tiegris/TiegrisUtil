using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiegrisUtil.Math
{
    public class PredeterminedRandom : IRandom
    {
        protected int[] iResults;
        protected double[] dResults;
        protected int iFollowup;
        protected double dFollowup;

        protected int iIterator = 0;
        protected int dIterator = 0;

        public void Reset() {
            iIterator = 0;
            dIterator = 0;
        }

        public PredeterminedRandom(
            int[] intResults, double[] doubleResults, 
            int intFollowup, double doubleFollowup) {
            iResults = intResults;
            dResults = doubleResults;
            iFollowup = intFollowup;
            dFollowup = doubleFollowup;
        }

        protected double NextDouble() {
            if (dIterator < dResults.Length)
                return dResults[dIterator++];
            else
                return dFollowup;
        }

        protected int NextInt() {
            if (iIterator < iResults.Length)
                return iResults[iIterator++];
            else
                return iFollowup;
        }

        public bool ContinuousChance(int percent) {
             return NextInt() < percent;
        }

        public bool ContinuousChance(double probability) {
            return NextDouble() < probability;
        }

        public int ContinuousInt() {
            return NextInt();
        }

        public int ContinuousInt(int min, int max) {
            int next = NextInt();
            if (next < min || next >= max)
                throw new Exception("PredeterminedRandom exception. Next result is outside of bounds.");
            return next;
        }

        public double ContinuousDouble() {
            return NextDouble();
        }
    }
}
