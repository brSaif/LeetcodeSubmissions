public class Solution {
    public int[] PlusOne(int[] digits) {
         var carryOver=1;
        var currentValue=0;        
        for (int i=digits.Length-1; i>=0; i--)
        {
            currentValue=digits[i]+carryOver;
            digits[i]=currentValue%10;
            carryOver=currentValue/10;
        }
        if (carryOver!=0)
        {    
            var increasedSizeArray=new int[(digits.Length+1)];
            increasedSizeArray[0]=carryOver;
            Array.Copy(digits, 0, increasedSizeArray, 1, digits.Length);    
            return increasedSizeArray;
        }
        return digits;
    }
}