public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) 
        => image.Select(x => x.Reverse().Select(y => y^1).ToArray()).ToArray();
}