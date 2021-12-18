using System;
using System.Collections.Generic;
using System.Linq;

public class Mixing 
{
  public static string Mix(string s1, string s2)
  {
    char[] lowerCaseletters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    Dictionary<char, int> d1 = new Dictionary<char, int>();
    Dictionary<char, int> d2 = new Dictionary<char, int>();

    var s11 = s1.Where(x => lowerCaseletters.Contains(x));
    var s22 = s2.Where(x => lowerCaseletters.Contains(x));

    foreach (var letter in s11) { if (!d1.ContainsKey(letter)) { d1.Add(letter, 1); } else { d1[letter]++; } }
    foreach (var letter in s22) { if (!d2.ContainsKey(letter)) { d2.Add(letter, 1); } else { d2[letter]++; } }

    foreach (var item in d1.Where(item => item.Value < 2).ToList()) d1.Remove(item.Key);
    foreach (var item in d2.Where(item => item.Value < 2).ToList()) d2.Remove(item.Key);

    foreach (var item in d1.Keys.ToList()) { if (d2.Keys.Contains(item)) { if (d1[item] > d2[item]) { d2.Remove(item); } else if (d1[item] < d2[item]) { d1.Remove(item); } } }

    List<string> res = new List<string>();
    foreach (var item in d1.Keys.ToList()) { if (d2.Keys.Contains(item)) { res.Add($"=:{new string(item, d1[item])}"); d2.Remove(item); d1.Remove(item); } else { res.Add($"1:{new string(item, d1[item])}"); } }
    foreach (var item in d2.Keys.ToList()) { res.Add($"2:{new string(item, d2[item])}"); }


    return string.Join("/", res.OrderByDescending(x=>x.Length).ThenBy(y=>y[0]).ThenBy(z=>z[2]));
  }
}
