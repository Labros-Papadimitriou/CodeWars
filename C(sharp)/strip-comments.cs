using System.Text.RegularExpressions;

public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
      var lines = Regex.Split(text, @"\n");
      for (int i = 0; i < lines.Length; i++)
      {
        var line = lines[i];
        foreach (var commSymb in commentSymbols)
        {
          int symbIndex = line.IndexOf(commSymb);
          if (symbIndex >= 0)
          {
              line = line.Substring(0, symbIndex);
          }
        }
        lines[i] = line.TrimEnd();
      }
      return string.Join("\n", lines);
    }
}
