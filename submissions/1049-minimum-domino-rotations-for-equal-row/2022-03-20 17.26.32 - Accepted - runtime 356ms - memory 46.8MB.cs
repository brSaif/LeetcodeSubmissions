public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        var n = A.Length;
        var set = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
        var map = Enumerable.Range(0, 6).Select(x => new int[n]).ToArray();

        for (var i = 0; i < n; i++) {
            map[A[i] - 1][i]++;
            map[B[i] - 1][i]++;
        }

        for (var i = 0; i < 6; i++) {
            for (var j = 0; j < n; j++) {
                if (map[i][j] != 0) continue;
                set.Remove(i + 1);
                break;
            }
        }

        if (set.Count == 0)
            return -1;

        var e = set.First();
        var counts = new int[4];
        counts[0] = A.Count(x => x == e);
        counts[1] = n - counts[0];
        counts[2] = B.Count(x => x == e);
        counts[3] = n - counts[2];

        return counts.Min();
    }
}