using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
  public static int[] DeleteNth(int[] arr, int x) {
    List<int> result = new List<int>();
    for(int i = 0; i < arr.Length; i++)
    {
      if(result.Count(c=> c == arr[i]) < x )
      {
        result.Add(arr[i]);
      }
    }
    return result.ToArray();
  }
}
