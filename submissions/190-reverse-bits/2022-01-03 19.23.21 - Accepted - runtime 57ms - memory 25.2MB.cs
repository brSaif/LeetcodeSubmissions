public class Solution {
    public uint reverseBits(uint n) {
        uint res  = 0;
        int i = 1;
        while (i <= 32){
            var x = n & 1; // 
            n = n >> 1;
            res = res << 1;
            res = res | x;
            i++;
        }
        return res;
    }
}