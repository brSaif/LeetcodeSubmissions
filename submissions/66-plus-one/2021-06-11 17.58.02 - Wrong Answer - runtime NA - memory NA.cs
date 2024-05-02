public class Solution {
    public int[] PlusOne(int[] digits) {
        int carryOver = 0;
        List<int> digList = new List<int>(digits);
        for(int i = digits.Length -1; i >=0  ; i--){
            
            if(digList[i] < 8) {
                digList[i] +=  carryOver ;
                carryOver = 0;
                break;
                }else {
                digList[i] = 0;
                carryOver = 1;
            }
            
            if(digits[0] == 9 && i == 0){
                digList.Insert(0,carryOver);
            }
            
        }
        
        
        
        return digList.ToArray();
    }
}