public class Solution {
    public int GetSum(int a, int b) {
        while(b != 0){
            int tmp = (a & b) << 1;
            a = a ^ b;
            b = tmp;
        }
        return  a;
    }
}