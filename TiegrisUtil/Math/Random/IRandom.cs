namespace TiegrisUtil.Math
{
    public interface IRandom
    {
        public bool ContinuousChance(int percent);
        public bool ContinuousChance(double probability);
        public double ContinuousDouble();
        public int ContinuousInt();
        public int ContinuousInt(int min, int max);
    }
}