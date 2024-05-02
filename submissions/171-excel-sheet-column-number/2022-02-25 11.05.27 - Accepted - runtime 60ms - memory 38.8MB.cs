public class Solution {
    public int TitleToNumber(string columnTitle) 
        => columnTitle.Aggregate(0, (acc, x) => acc * 26 + x - 'A' + 1);
}