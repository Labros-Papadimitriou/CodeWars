using System;
using System.Text;

public class Kata {
  public static string Assemble(string[] copies) {
    if(copies.Length == 0)
    {
      return "";  
    }
    string result = new string('%', copies[0].Length);
    
    StringBuilder sb = new StringBuilder(result);
    
    for(int i = 0; i < result.Length; i++)
    {
      foreach(var copy in copies)
      {
        if(copy[i] != '*')
        {
          if(sb[i] == '#' || sb[i] == '%' )
          {
            sb[i] = copy[i]; 
          }
        }
        else
        {
          if(sb[i] == '%' || sb[i] == '#')
          {
             sb[i] = '#'; 
          }
        }
      }
    }
    result = sb.ToString();
    return result;
    }
  }
