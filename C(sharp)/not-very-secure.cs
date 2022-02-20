using System.Text.RegularExpressions;
public class Kata
{
  public static bool Alphanumeric(string str)
  {
    return new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
    
  }
}
