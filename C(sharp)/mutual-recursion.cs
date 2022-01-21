using System;
using System.Collections.Generic;

public class Kata
{
    public static List<int> female = new List<int>();
    public static List<int> male = new List<int>();

    public static int F(int n)
    {
        if (n == 0) return 1;
        if (n < female.Count)
        {
          return female[n];
        }
        female.Add(n - M(F(n - 1)));
        return n - M(F(n - 1));
    }
    public static int M(int n)
    {
        if (n == 0) return 0;
        if (n < male.Count)
        { 
          return male[n];
        }
        male.Add(n - F(M(n - 1)));
        return n - F(M(n - 1));
    }
}
