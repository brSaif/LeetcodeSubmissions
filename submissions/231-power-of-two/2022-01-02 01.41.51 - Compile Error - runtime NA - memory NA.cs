public class Solution {
    public bool IsPowerOfTwo(int n) {
        while (n > 0){
            n = (n ^ 2) >> 2;
        }
   
        return n == ;
    }
}