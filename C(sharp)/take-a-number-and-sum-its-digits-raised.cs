using System;
using System.Collections.Generic;
public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
      long sum = 0;
      List<long> result = new List<long>();

      for (long i = a; i < b ; i++)
      {
        int count = 1;
        foreach (char n in i.ToString())
        {
            sum += Convert.ToInt64(Math.Pow(Convert.ToInt64(n.ToString()), count));
            count++;
        }
        count = 1;
        if (sum == i)
        {
            result.Add(sum);
        }
        sum = 0;
    }
      return result.ToArray();
    }
}
