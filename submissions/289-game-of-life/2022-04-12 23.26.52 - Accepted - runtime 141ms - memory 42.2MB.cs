public class Solution {
    public void GameOfLife(int[][] board) {
        int n = board.Length;
            if (n == 0)
            {
                return;
            }

            int m = board[0].Length;


            (int di, int dj)[] dirs = new (int di, int dj)[]
            {
                (0,1),
                (0,-1),
                (1,0),
                (-1,0),
                (1,1),
                (1,-1),
                (-1,1),
                (-1,-1)
            };


            //2 - dead to live
            //3 - live to dead

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    int liveCount = 0;
                    foreach (var dir in dirs)
                    {
                        int newI = i + dir.di;
                        int newJ = j + dir.dj;

                        if (newI >= 0 && newI < n && newJ >= 0 && newJ < m)
                        {
                            if (board[newI][newJ] == 1 || board[newI][newJ] == 3)
                            {
                                liveCount++;
                            }
                        }
                    }


                    if (board[i][j] == 0)
                    {
                        if (liveCount == 3)
                        {
                            board[i][j] = 2;
                        }

                        continue;
                    }

                    if (liveCount < 2)
                    {
                        board[i][j] = 3;
                        continue;
                    }

                    if (liveCount > 3)
                    {
                        board[i][j] = 3;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == 2)
                    {
                        board[i][j] = 1;
                        continue;
                    }

                    if (board[i][j] == 3)
                    {
                        board[i][j] = 0;
                        continue;
                    }
                }
            }

        }
}