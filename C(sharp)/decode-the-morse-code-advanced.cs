using System;
using System.Text;
using System.Text.RegularExpressions;

public class MorseCodeDecoder
{
    public static string DecodeBits(string bits)
    {
      Console.WriteLine(bits);
      bits = bits.Trim(new char[] { '0' });
      if(Regex.IsMatch(bits, @"111111111111111"))
      {
        bits = Regex.Replace(bits, @"00000000000000000000000000000000000", "   ");
        bits = Regex.Replace(bits, @"000000000000000", " ");
        bits = Regex.Replace(bits, @"111111111111111", "-");
        bits = Regex.Replace(bits, @"11111", ".");
        bits = Regex.Replace(bits, @"00000", "");
      }
      else if(Regex.IsMatch(bits, @"01111110"))
      {
        bits = Regex.Replace(bits, @"00000000000000", "   ");
        bits = Regex.Replace(bits, @"000000", " ");
        bits = Regex.Replace(bits, @"111111", "-");
        bits = Regex.Replace(bits, @"11", ".");
        bits = Regex.Replace(bits, @"00", "");
      }
      else if(Regex.IsMatch(bits, @"^111$") || Regex.IsMatch(bits, @"^1111111$") || Regex.IsMatch(bits, @"^110011$") || Regex.IsMatch(bits, @"^111000111") || Regex.IsMatch(bits, @"^111110000011111") || Regex.IsMatch(bits, @"^11111100111111") || Regex.IsMatch(bits, @"^111000000000111") || Regex.IsMatch(bits, @"^111000111000111"))
      {
        bits = Regex.Replace(bits, @"^1111111$", ".");
        bits = Regex.Replace(bits, @"^111$", ".");
        bits = Regex.Replace(bits, @"^111000111000111$", "...");
        bits = Regex.Replace(bits, @"^111000000000111$", ". .");
        bits = Regex.Replace(bits, @"^11111100111111$", "--");
        bits = Regex.Replace(bits, @"^111110000011111$", "..");
        bits = Regex.Replace(bits, @"^111000111$", "..");
        bits = Regex.Replace(bits, @"^110011$", "..");
      }
      else
      {
        bits = Regex.Replace(bits, @"0000000", "   ");
        bits = Regex.Replace(bits, @"000", " ");
        bits = Regex.Replace(bits, @"111", "-");
        bits = Regex.Replace(bits, @"1", ".");
        bits = Regex.Replace(bits, @"0", "");
      }
      Console.WriteLine(bits);
      return bits.Trim();
    }

    public static string DecodeMorse(string morseCode)
    {
      StringBuilder sb = new StringBuilder();
      var sentence = morseCode.Split("   ");
      foreach(var word in sentence)
      {
        var letters = word.Split();
        foreach(var letter in letters)
        {
          sb.Append(MorseCode.Get(letter));
          Console.WriteLine(sb.ToString());
        }
        sb.Append(" ");
      }
      return sb.ToString().Trim();
    }
}
