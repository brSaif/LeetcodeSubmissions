public class Solution {
    public int ClosedIsland(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
    var visitedSet = new HashSet<(int, int)>();
    int count = 0;
    bool isClosed;
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++)
        {
            isClosed = true;
            if (grid[i][j] == 0 && !visitedSet.Contains((i, j)))
            {
                IsClosedIsland(i, j);
                if (isClosed)
                    count++;
            }
        }
    }

    return count;

    void IsClosedIsland(int i1, int j1)
    {
        if (visitedSet.Contains((i1, j1)))
            return;

        visitedSet.Add((i1, j1));
        if (i1 == n - 1 || i1 == 0 || j1 == m - 1 || j1 == 0)
            isClosed = false;

        if (i1 != 0 && grid[i1 - 1][j1] == 0)
            IsClosedIsland(i1 - 1, j1);
        if (i1 != n - 1 && grid[i1 + 1][j1] == 0)
            IsClosedIsland(i1 + 1, j1);
        if (j1 != m - 1 && grid[i1][j1 + 1] == 0)
            IsClosedIsland(i1, j1 + 1);
        if (j1 != 0 && grid[i1][j1 - 1] == 0)
            IsClosedIsland(i1, j1 - 1);
    }
    }
}