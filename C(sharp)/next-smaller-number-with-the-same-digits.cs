using System;
public class Kata
{
  public static long NextSmaller(long n)
  {
    char[] chars = n.ToString().ToCharArray();

    int[] ints = new int[chars.Length];
    for (int i = 0; i < chars.Length; i++)
    {
        ints[i] = chars[i] - '0';
    }

    int startingIndex = ints.Length - 1;
    for (int i = ints.Length - 2; i >= 0; i--)
    {
        int max = i == 0 ? 0 : int.MinValue;
        int maxIndex = -1;
        for (int j = i + 1; j < ints.Length; j++)
        {
            if (ints[j] > max && ints[j] < ints[i])
            {
                max = ints[j];
                maxIndex = j;
            }
        }
        if (maxIndex >= 0)
        {
            int temp = ints[maxIndex];
            ints[maxIndex] = ints[i];
            ints[i] = temp;

            startingIndex = i;
            break;
        }
    }
    for (int i = startingIndex + 1; i < ints.Length - 1; i++)
    {
        int max = ints[i];
        int sortIndex = i;
        for (int j = i; j < ints.Length; j++)
        {
            if (ints[j] > max)
            {
                max = ints[j];
                sortIndex = j;
            }
        }

        int temp = ints[i];
        ints[i] = max;
        ints[sortIndex] = temp;
    }
    string newNum = "";
    for (int i = 0; i < ints.Length; i++)
    {
        newNum += ints[i];
    }
    long newValue = Convert.ToInt64(newNum);
    return newValue == n ? -1 : newValue;
  }
}
