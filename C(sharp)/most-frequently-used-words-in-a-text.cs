using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class TopWords
{
    public static List<string> Top3(string s)
    {
      Dictionary<string, int> dict = new Dictionary<string, int>();
      var str = Regex.Split(s.ToLower(), @"[^'a-zA-Z]").Where(w => w.Length > 0);

      foreach (var word in str)
      {
          if(!dict.ContainsKey(word))
          {
              dict[word] = 0;
          }
          else
          {
              dict[word]++;
          }
      }
      var ordered = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

      if (ordered.Count >=3)
      {
          return new List<string> { ordered.Keys.ToList()[0], ordered.Keys.ToList()[1], ordered.Keys.ToList()[2] };
      }
      else if (ordered.Count == 2)
      {
          return new List<string> { ordered.Keys.ToList()[0], ordered.Keys.ToList()[1] };
      }
      else if (ordered.Count == 1)
      {
        return ordered.Keys.ToList()[0] == "'" || ordered.Keys.ToList()[0] == "'''" ? new List<string>() { } : new List<string>() { ordered.Keys.ToList()[0] };
      }
      else
      {
          return new List<string> { };
      }
    }
}
