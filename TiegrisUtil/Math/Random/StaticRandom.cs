using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiegrisUtil.Math
{
    public static class StaticRandom
    {
        public static IRandom Instance { get; set; }
        public static bool ContinuousChance(int percent) => Instance.ContinuousChance(percent);
        public static bool ContinuousChance(double probability) => Instance.ContinuousChance(probability);
        public static int ContinuousInt() => Instance.ContinuousInt();
        public static int ContinuousInt(int min, int max) => Instance.ContinuousInt(min, max);
    }
}
