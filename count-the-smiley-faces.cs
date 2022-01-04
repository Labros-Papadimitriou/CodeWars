using System.Linq;
public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
     return smileys.ToList().Count(c=>c==":)" || c==";)" || c==":-)" || c==":~)" || c==";-)" || c==";~)" || c==":D" || c==";D" || c==":-D" || c==":~D" || c==";-D" || c==";~D");
  }
}
