public class Solution {
    public int GetSum(int a, int b) {
        while (b != 0){
            int tmp = (a & b) << 1;
            a ^= b;
            b = tmp;
        }
        
        return a;
    }
}


// 2    3       5
// 0010 0011 => 0101
