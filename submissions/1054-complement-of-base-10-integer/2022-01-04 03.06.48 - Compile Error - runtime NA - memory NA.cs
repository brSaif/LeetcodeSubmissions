public class Solution {
    public int BitwiseComplement(int n)
        => return n == 0 ? 1 : n ^ (1 << ((int) Math.Log(n,2) + 1) - 1); 
}