using System;
using System.Linq;

public class Kata
{
    static string[] Numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
    public static string AverageString(string str)
    {
        if (!str.Split().All(Numbers.Contains)) return "n/a";
        return Numbers[(int)Math.Floor(str.Split().Select(x => Array.IndexOf(Numbers, x)).Average())];
    }
}
