using System;
using System.Linq;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if(a==null || b==null){return false;}
    return a.Select(s=>Convert.ToInt32(Math.Pow(s,2))).OrderBy(x=>x).ToArray().SequenceEqual(b.OrderBy(x=>x).ToArray());
  }
}
