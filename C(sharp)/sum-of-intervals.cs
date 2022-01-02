using System;
using Interval = System.ValueTuple<int, int>;
using System.Collections.Generic;
public class Intervals
{
        public static int SumIntervals((int, int)[] intervals)
        {
            HashSet<int> p = new HashSet<int>();
            foreach (var item in intervals)
            {
                for (int i = item.Item1; i < item.Item2; i++)
                {                   
                    p.Add(i);
                }
            }
            return p.Count;
        }
}
