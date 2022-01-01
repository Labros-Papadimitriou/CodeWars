using System.Linq;
using System.Text.RegularExpressions;
public class Scramblies 
{ 
  public static bool Scramble(string str1, string str2) 
  {
    foreach (var letter in str2)
    {
      if (str1.Contains(letter))
      {
        Regex rgx = new Regex(@"" + letter + @"");
        str1 = rgx.Replace(str1, "", 1);
      }
      else
      {
        return false;
      }
    }
    return true;
  }
}
