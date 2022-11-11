using System;

namespace CellBehaviorSimulator
{
    public static class RandomGen2
    {
        private static Random _global = new Random();
        [ThreadStatic]
        private static Random _local;

        public static int Next(int maxValue)
        {
            Random inst = _local;
            if (inst == null)
            {
                int seed;
                lock (_global) seed = _global.Next();
                _local = inst = new Random(seed);
            }
            return inst.Next(maxValue);
        }
        public static double NextDouble()
        {
            Random inst = _local;
            if (inst == null)
            {
                int seed;
                lock (_global) seed = _global.Next();
                _local = inst = new Random(seed);
            }
            return inst.NextDouble();
        }
    }
}
