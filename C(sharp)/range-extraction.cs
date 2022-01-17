using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class RangeExtraction
{
  public static string Extract(int[] args)
  {
    var allNums = Enumerable.Range(args.First(), args.Last() - args.First() + 1);
    List<string> li = new List<string>();
    foreach (var num in allNums)
    {
        if (args.Contains(num))
        {
            li.Add(num + " ");
        }
        else
        {
            li.Add("  ");
        }
    }

    List<string> newLi = Regex.Split(string.Concat(li), @"\s{2,}").ToList();
    newLi = newLi.Select(s => s.Trim()).ToList();

    return string.Join(",", newLi.Select(w => w.All(a=>!char.IsWhiteSpace(a)) ? Convert.ToInt32(w).ToString() : Convert.ToInt32(w.Split().Last()) - Convert.ToInt32(w.Split().First()) >= 2 ? w.Split().First() + "-" + w.Split().Last() : w.Split().First() + "," + w.Split().Last()));
  }
}
