public class Solution {
    public int BitwiseComplement(int n) {
        int i = 1;
        while ((i & n) != n)
            i = (i<<1)+1;
        return n^i;
    }
}