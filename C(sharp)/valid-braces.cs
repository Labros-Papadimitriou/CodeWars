using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Brace 
{
    public static bool validBraces(String str) 
    {
      for (int i = 0; i < str.Length+4; i++)
      {
          str = Regex.Replace(str, @"\(\)|\{\}|\[\]", "");
      }
      return str.Length == 0;
    }
}
