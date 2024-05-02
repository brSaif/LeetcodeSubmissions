public class Solution {
    public int MinPartitions(string n) 
        => Array.ConvertAll(n.ToCharArray(), n => (int)Char.GetNumericValue(n)).Max();
}