using System;
using System.Linq;

public class Kata
{
  public static bool ValidateString(string[] dictionary, string word)
  {
   if (word.Length == 0)
    {
        return true;
    }
    foreach (var substring in dictionary)
    {
        if (word.StartsWith(substring))
        {
            if (ValidateString(dictionary, word.Substring(substring.Length)))
            {
                return true;
            }
        } 
    }
    return false;
  }
}
