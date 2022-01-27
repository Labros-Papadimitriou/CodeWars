namespace smile67Kata
{
using System;
using System.Text.RegularExpressions;
using System.Linq;
public class Kata
{
  public string calculateString(string calcIt) 
  {
    var temp = calcIt
          .Split('*', '/', '+', '-')
          .Select(x => String.Concat(x.ToCharArray().Where(y => Char.IsDigit(y) || y == '.')))
          .ToArray();
      double result;
      if (calcIt.Contains('*'))
          result = (double.Parse(temp[0]) * double.Parse(temp[1]));
      else if (calcIt.Contains('/'))
          result = (double.Parse(temp[0]) / double.Parse(temp[1]));
      else if (calcIt.Contains('+'))
          result = (double.Parse(temp[0]) + double.Parse(temp[1]));
      else
          result = (double.Parse(temp[0]) - double.Parse(temp[1]));

      return Convert.ToInt64(result).ToString();
    }
  }
} 
