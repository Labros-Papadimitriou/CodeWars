using System;

public class ToSmallest 
{
  public static long[] Smallest (long n)
  {
    var result = new long[] { n, 0, 0 };
    var str = n + "";

    for (int i = 0; i < str.Length; i++)
    {
        var subStr = str.Substring(i, 1);
        var rem = str.Remove(i, 1);

        for (int j = 0; j < str.Length; j++)
        {
            var newN = Convert.ToInt64(rem.Insert(j, subStr));
            if (newN < result[0])
            {
                result[0] = newN;
                result[1] = i;
                result[2] = j;
            }
        }
    }
    return result;
  }
}
