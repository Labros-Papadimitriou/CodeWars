using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
  {
    if (arrayOfArrays == null || arrayOfArrays.Length == 0)
    {
        return 0;
    }
    if (arrayOfArrays.Any(a => a == null || a.Length == 0))
    {
        return 0;
    }
    var numSorted = arrayOfArrays.Select(x=>x.Length).OrderBy(x=>x);
    var result = Enumerable.Range(numSorted.First(), numSorted.Last() - numSorted.First()+1).Sum() - numSorted.Sum();
    return result;
  }
}
