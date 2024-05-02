public class Solution {
    public int MaximumWealth(int[][] accounts) {
        return accounts.Select(row => row.Sum()).Max();
    }
}