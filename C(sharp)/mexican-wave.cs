using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
  public class Kata
  {
    public List<string> wave(string str)
    {
      return str.Select((c,i) => str.Substring(0,i) + char.ToUpper(c) + str.Substring(i+1)).Where(x => x != str).ToList();
    }
  }
}
