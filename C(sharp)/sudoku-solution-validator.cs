public class Sudoku
{
  public static bool ValidateSolution(int[][] board)
  {
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (board[i][j] <= 0 || board[i][j] > 9)
            {
                return false;
            }
        }
    }

    for (int i = 0;i < 9; i++)
    {
        bool[] unique = new bool[10] { false, false, false, false, false, false, false, false, false, false };

        for (int j = 0; j < 9; j++)
        {
            int z = board[i][j];
            if (unique[z])
            {
                return false;
            }
            unique[z] = true;
        }
    }

    for (int i = 0; i < 9; i++)
    {
        bool[] unique = new bool[10] { false, false, false, false, false, false, false, false, false, false };

        for (int j = 0; j < 9; j++)
        {
            int z = board[j][i];
            if (unique[z])
            {
                return false;
            }
            unique[z] = true;
        }
    }

    for (int i = 0; i < 9 - 2; i += 3)
    {
        for (int j = 0; j < 9 - 2; j += 3)
        {
            bool[] unique = new bool[10] { false, false, false, false, false, false, false, false, false, false };

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    int X = i + k;
                    int Y = j + l;
                    int Z = board[X][Y];

                    if (unique[Z])
                    {
                        return false;
                    }
                    unique[Z] = true;
                }
            }
        }
    }
    return true;
  }
}
