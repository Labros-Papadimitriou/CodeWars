using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
  public static string CleanString(string s)
  {
    var a = Regex.Split(s, string.Empty);

    for (int i = 0; i < a.Length; i++)
      {
        if (a[i] == "#")
        {
          a[i] = "";
          a[i - 1] = "";
          a = a.Where(v => v != "").ToArray();
          i = 0;
        }
      }
      return string.Join("", a).TrimStart('#');
  }
}
